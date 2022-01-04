using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Petshop.view
{
    public partial class relatoriofechamento : Form
    {
        public double totalvendas = 0;
        public relatoriofechamento()
        {
            InitializeComponent();
        }

        public void carregarlv()
        {
            lv_fechar.LabelEdit = false;
            lv_fechar.AllowColumnReorder = true;
            lv_fechar.FullRowSelect = true;
            try
            {
                Conexao conexao = new Conexao();
               
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@data", DateTime.Today);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexao.Conectar();

                cmd.CommandText = "select * from venda where data = @data AND forma_pagamento = 'Dinheiro'";
                
                SqlDataReader venda = cmd.ExecuteReader();
                lv_fechar.Items.Clear();
                while (venda.Read())
                {
                    var lista = new ListViewItem(venda.GetInt32(0).ToString());
                    lista.SubItems.Add("R$" + venda.GetDouble(1).ToString("F2"));
                    lista.SubItems.Add(venda.GetString(2));
                    totalvendas = totalvendas + double.Parse(venda.GetDouble(1).ToString("F2"));
                    lv_fechar.Items.Add(lista);
                }
                conexao.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
        }

        public void balanco()
        {
            if(tb_abertura.Text != string.Empty && tb_fechamento.Text != string.Empty)
            {
                string[] valorinicial = tb_abertura.Text.Split("R$ ");
                double valorcaixa = double.Parse(valorinicial[1]) + totalvendas;
                lb_valorcaixa.Text = valorcaixa.ToString("F2");

                string[] valorfinal = tb_fechamento.Text.Split("R$");
                double valorfinalcaixa = double.Parse(valorfinal[1]);
                double balanco = valorfinalcaixa - valorcaixa;
                lb_balanco.Text = balanco.ToString("F2");
                totalvendas = 0;
            }
            else{
                MessageBox.Show("Inserir valor de abertura e fechamento.");
            }

            

        }

        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;

            try
            {

                n = txt.Text.Replace("R$ ", "").Replace(",", "").Replace(".", "");

                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;

                txt.Text = string.Format("{0:C2}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }
        }

        private void bt_gerarelatorio_Click(object sender, EventArgs e)
        {
            carregarlv();
            balanco();

          

        }

        private void tb_abertura_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref tb_abertura);
        }

        private void tb_fechamento_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref tb_fechamento);
        }

        private void tb_abertura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void tb_fechamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        public void GerarRelatorio()
        {
            // cria o documento (227, 400) para cupom fiscal, para a4 (pagesize.A4)
            Document relatorio = new Document(new iTextSharp.text.Rectangle(PageSize.A4));
            //seta as margens da pagina
            relatorio.SetMargins(10, 10, 10, 10);

            relatorio.AddCreationDate();
            //var data1 = DateTime.Today.ToString();
            //string[] datahoje = data1.Split("-");
            //string datafechamento = datahoje[0] + datahoje[1] + datahoje[2];

            //MessageBox.Show(datafechamento);
            Random rnd = new Random(2000);
            //cria o diretorio
            string diretorio1 = @"D:\relatoriosprojeto\fechamento\fechamentodecaixa" + DateTime.Today.ToString("dd-MM-yyyy") + ".pdf";

            //salva o arquivo
            PdfWriter salvar = PdfWriter.GetInstance(relatorio, new FileStream(diretorio1, FileMode.Create));

            // abrir relatorio para edita-lo
            relatorio.Open();
            // ---------------------------------------------------------------------------------------------//
            // gerar paragrafo
            Paragraph nomeempresa = new Paragraph();

            // define fonte do paragrafo
            nomeempresa.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10);
            nomeempresa.Alignment = Element.ALIGN_CENTER;
            // definir espaçamento entre linhas
            nomeempresa.SetLeading(1, 1);
            nomeempresa.Add("Nipon Pet Center \n");
            relatorio.Add(nomeempresa);

            // --------------------------------------------------------------------------------------------//
            Paragraph titulo = new Paragraph();
            // define fonte do paragrafo
            titulo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 14);
            titulo.Alignment = Element.ALIGN_CENTER;
            // definir espaçamento entre linhas
            titulo.SetLeading(1, 1);
            titulo.Add("Relatório de fechamento de caixa \n\n");
            relatorio.Add(titulo);
            // --------------------------------------------------------------------------------------------//
            PdfPTable itensrelatorio = new PdfPTable(3);
            itensrelatorio.DefaultCell.Border = 0;
            itensrelatorio.WidthPercentage = 100;
            var fontecelula = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12);
            itensrelatorio.AddCell(new Phrase("ID", fontecelula));
            itensrelatorio.AddCell(new Phrase("Valor Total", fontecelula));
            itensrelatorio.AddCell(new Phrase("Forma de pagamento", fontecelula));
            
           
            for (int i = 0; i < lv_fechar.Items.Count; i++)
            {
                itensrelatorio.AddCell(new Phrase(lv_fechar.Items[i].SubItems[0].Text, fontecelula));
                itensrelatorio.AddCell(new Phrase(lv_fechar.Items[i].SubItems[1].Text, fontecelula));
                itensrelatorio.AddCell(new Phrase(lv_fechar.Items[i].SubItems[2].Text, fontecelula));
            }

            itensrelatorio.AddCell(new Phrase("", fontecelula));
            itensrelatorio.AddCell(new Phrase("", fontecelula));

            relatorio.Add(itensrelatorio);

            //---------------------------------------------------------------------------------------------//

            
            PdfPTable informacoes = new PdfPTable(3);
            informacoes.DefaultCell.Border = 0;
            informacoes.WidthPercentage = 100;
            informacoes.AddCell(new Phrase("Total: R$" + lb_valorcaixa.Text, fontecelula));
            informacoes.AddCell(new Phrase("", fontecelula)); // quantidade
            informacoes.AddCell(new Phrase("", fontecelula));
            
            relatorio.Add(informacoes);
            // -------------------------------------------------------------------------------------------- //

            PdfPTable informacoes1 = new PdfPTable(3);
            informacoes1.DefaultCell.Border = 0;
            informacoes1.WidthPercentage = 100;
            informacoes1.AddCell(new Phrase("Balanço: R$" + lb_balanco.Text, fontecelula));
            informacoes1.AddCell(new Phrase("", fontecelula)); // quantidade
            informacoes1.AddCell(new Phrase("", fontecelula));

            relatorio.Add(informacoes1);
            // -------------------------------------------------------------------------------------------- //
            var data = DateTime.Today.ToString("dd-MM-yyyy"); // função para pegar a data atual
            PdfPTable informacoes2 = new PdfPTable(3);
            informacoes2.DefaultCell.Border = 0;
            informacoes2.WidthPercentage = 100;
            informacoes2.AddCell(new Phrase("", fontecelula));
            informacoes2.AddCell(new Phrase("Data: " + data, fontecelula)); // quantidade
            informacoes2.AddCell(new Phrase("", fontecelula));

            relatorio.Add(informacoes2);
            relatorio.Close();
        }

        private void bt_pdf_Click(object sender, EventArgs e)
        {
            GerarRelatorio();
            MessageBox.Show("Relatório gerado.");
        }
    }
}
