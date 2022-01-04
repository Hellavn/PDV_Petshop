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
    public partial class RelatorioVendaPorPeriodo : Form
    {
        public DateTime dataincial;
        public DateTime datafinal;
        double totalvenda = 0;
        public bool pegainicial = false;
        public bool pegafinal = false;
        public RelatorioVendaPorPeriodo()
        {
            InitializeComponent();
            cal_datainicial.MaxDate = DateTime.Today;
            cal_datafinal.MaxDate = DateTime.Today;
        }

        private void RelatorioVendaPorPeriodo_Load(object sender, EventArgs e)
        {

        }
        public void carregar_lv()
        {
            if (pegainicial && pegafinal)
            {
                lv_relatorio.LabelEdit = true;
                lv_relatorio.AllowColumnReorder = true;
                lv_relatorio.FullRowSelect = true;
                try
                {
                    Conexao con = new Conexao();
                    SqlCommand cmd = new SqlCommand();
                    totalvenda = 0;

                    cmd.Parameters.AddWithValue("@datainicial", dataincial);
                    cmd.Parameters.AddWithValue("@datafinal", datafinal);

                    cmd.CommandText = "select v.id_venda, v.total_venda, v.forma_pagamento, v.data, u.nome_usuario from venda as v " +
                    "inner join usuario as u on v.id_usuario = u.id_usuario " +
                    "where v.data between @datainicial and @datafinal " +
                    "order by v.data desc";

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con.Conectar();
                    SqlDataReader relatorio = cmd.ExecuteReader();
                    lv_relatorio.Items.Clear();
                    while (relatorio.Read())
                    {
                        //id venda, valor total, formadepagamento, data, nome usuario
                        var lv = new ListViewItem(relatorio.GetInt32(0).ToString()); // id
                        lv.SubItems.Add(relatorio.GetDouble(1).ToString("F2")); // nome 
                        lv.SubItems.Add(relatorio.GetString(2)); // quantidade                    
                        lv.SubItems.Add(relatorio.GetDateTime(3).ToString()); // quantidade                    
                        lv.SubItems.Add(relatorio.GetString(4)); //valor
                        totalvenda = totalvenda + double.Parse(relatorio.GetDouble(1).ToString("F2"));
                        lv_relatorio.Items.Add(lv);
                    }
                    con.Desconectar();
                }
                catch (SqlException erro)
                {
                    MessageBox.Show("Erro ao buscar no banco de dados!!! \n" + erro);
                }
            }
            else
            {
                MessageBox.Show("Favor selecionar data inicial e final.");
            }
            
        }
        private void bt_gerar_Click(object sender, EventArgs e)
        {
            carregar_lv();
        }
        public void GerarRelatorio(string diretorio)
        {
            // cria o documento (227, 400) para cupom fiscal, para a4 (pagesize.A4)
            Document relatorio = new Document(new iTextSharp.text.Rectangle(PageSize.A4));
            //seta as margens da pagina
            relatorio.SetMargins(10, 10, 10, 10);

            relatorio.AddCreationDate();

            Random rnd = new Random(2000);
            // cria o diretoria
            //string diretorio = @"D:\relatoriosprojeto\produto_mais_vendido\produto_mais_vendido_"+rnd.Next()+".pdf";

            //salva o arquivo
            PdfWriter salvar = PdfWriter.GetInstance(relatorio, new FileStream(diretorio, FileMode.Create));

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
            titulo.Add("Relatório de vendas por periodo \n\n");
            relatorio.Add(titulo);
            // --------------------------------------------------------------------------------------------//
            PdfPTable itensrelatorio = new PdfPTable(5);
            itensrelatorio.DefaultCell.Border = 0;
            itensrelatorio.WidthPercentage = 100;
            var fontecelula = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12);
            itensrelatorio.AddCell(new Phrase("ID", fontecelula));
            itensrelatorio.AddCell(new Phrase("Valor Total", fontecelula));
            itensrelatorio.AddCell(new Phrase("Forma de pagamento", fontecelula));
            itensrelatorio.AddCell(new Phrase("Data", fontecelula));
            itensrelatorio.AddCell(new Phrase("Usuario", fontecelula));
            // id marca, , nome da marca, quantidade, valor
            for (int i = 0; i < lv_relatorio.Items.Count; i++)
            {
                itensrelatorio.AddCell(new Phrase(lv_relatorio.Items[i].SubItems[0].Text, fontecelula));
                itensrelatorio.AddCell(new Phrase(lv_relatorio.Items[i].SubItems[1].Text, fontecelula));
                itensrelatorio.AddCell(new Phrase(lv_relatorio.Items[i].SubItems[2].Text, fontecelula));
                itensrelatorio.AddCell(new Phrase(lv_relatorio.Items[i].SubItems[3].Text, fontecelula));
                itensrelatorio.AddCell(new Phrase(lv_relatorio.Items[i].SubItems[4].Text, fontecelula));
               
            }

            itensrelatorio.AddCell(new Phrase("", fontecelula));
            itensrelatorio.AddCell(new Phrase("", fontecelula));

            relatorio.Add(itensrelatorio);

            //---------------------------------------------------------------------------------------------//
            var data = DateTime.Today.ToString("dd-MM-yyyy"); // função para pegar a data atual

            PdfPTable informacoes = new PdfPTable(3);
            informacoes.DefaultCell.Border = 0;
            informacoes.WidthPercentage = 100;
            informacoes.AddCell(new Phrase("Total: R$" + totalvenda.ToString("F2"), fontecelula)); 
            informacoes.AddCell(new Phrase("Data: " + data, fontecelula)); // quantidade
            informacoes.AddCell(new Phrase("", fontecelula)); 

            relatorio.Add(informacoes);
            // -------------------------------------------------------------------------------------------- //
            relatorio.Close();
        }
        private void bt_pdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dirDialog = new SaveFileDialog())
            {
                dirDialog.Filter = "Arquivo PDF (.pdf)|.pdf";

                DialogResult res = dirDialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    string salvar = dirDialog.FileName;
                    GerarRelatorio(salvar);
                    MessageBox.Show("Relatório salvo.");
                }
                else
                {
                    MessageBox.Show("Operação cancelada");
                }
            }
        }

        private void cal_datainicial_DateSelected(object sender, DateRangeEventArgs e)
        {
            dataincial = cal_datainicial.SelectionStart;
            pegainicial = true;
        }

        private void cal_datafinal_DateSelected(object sender, DateRangeEventArgs e)
        {
            datafinal = cal_datafinal.SelectionStart;
            pegafinal = true;
        }
    }
}
