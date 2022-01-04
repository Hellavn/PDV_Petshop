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
    public partial class Relatoriomarcaoucategoria : Form
    {
        public string escolha;
        public double valortotal;
        public Relatoriomarcaoucategoria()
        {
            InitializeComponent();
        }

        public void carregar_lv()
        {
            lv_relatorio.LabelEdit = true;
            lv_relatorio.AllowColumnReorder = true;
            lv_relatorio.FullRowSelect = true;
            try
            {
                Conexao con = new Conexao();
                SqlCommand cmd = new SqlCommand();
                
                bool pesquisa = false;

                cmd.Parameters.AddWithValue("@datainicial", cal_inicial.SelectionStart);
                cmd.Parameters.AddWithValue("@datafinal", cal_final.SelectionStart);
                   
                if(check_marca.Checked || check_categoria.Checked)
                {
                    if (escolha.Equals("marca"))
                    {
                        cmd.CommandText = "SELECT p.id_marca, p.marca, COUNT(p.marca) as quantidade_produto, SUM(i.valor_total_itens) as 'Valor vendido' " +
                        "FROM itens as i " +
                        "INNER JOIN produto as P on i.id_produto = p.id_produto " +
                        "where i.data_venda between @datainicial and @datafinal " +
                        "GROUP BY  p.marca, p.id_marca " +
                        "ORDER BY quantidade_produto DESC";
                        pesquisa = true;
                    }

                    if (escolha.Equals("categoria"))
                    {
                        cmd.CommandText = "SELECT p.id_categoria, p.categoria, COUNT(p.categoria) as quantidade_produto, SUM(i.valor_total_itens) as 'Valor vendido' " +
                        "FROM itens as i " +
                        "INNER JOIN produto as P on i.id_produto = p.id_produto " +
                        "where i.data_venda between @datainicial and @datafinal " +
                        "GROUP BY  p.categoria, p.id_categoria " +
                        "ORDER BY quantidade_produto DESC";
                        pesquisa = true;
                    }
                }
                else
                {
                    MessageBox.Show("Favor selecionar se deseja relatório de marca ou categoria");
                }
                

                
              
                if (pesquisa)
                {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con.Conectar();
                SqlDataReader relatorio = cmd.ExecuteReader();
                lv_relatorio.Items.Clear();
                while (relatorio.Read())
                {
                    var lv = new ListViewItem(relatorio.GetInt32(0).ToString()); // id
                    lv.SubItems.Add(relatorio.GetString(1)); // nome 
                    lv.SubItems.Add(relatorio.GetInt32(2).ToString()); // quantidade                    
                    lv.SubItems.Add(relatorio.GetDouble(3).ToString("F2")); //valor
                    valortotal = valortotal + double.Parse(relatorio.GetString(4).ToString());
                    lv_relatorio.Items.Add(lv);
                        
                }
                con.Desconectar();
                }
                else
                {
                    MessageBox.Show("Favor selecionar algum filtro de pesquisa.");
                }
                
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!! \n" + erro);
            }
        }
        
        private void bt_pdf_Click(object sender, EventArgs e)
        {

            
        }
        
        private void v_CheckedChanged(object sender, EventArgs e)
        {
            if (check_marca.Checked)
            {
                check_categoria.Enabled = false;
                
            }
            else
            {
                check_categoria.Enabled = true;
                
            }
            escolha = "marca";
        }

        private void check_categoria_CheckedChanged(object sender, EventArgs e)
        {
            if (check_categoria.Checked)
            {
                check_marca.Enabled = false;
                
            }
            else
            {
                check_marca.Enabled = true;
                
            }
            escolha = "categoria";
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
            titulo.Add("Relatório de vendas por marca/categoria \n\n");
            relatorio.Add(titulo);
            // --------------------------------------------------------------------------------------------//
            PdfPTable itensrelatorio = new PdfPTable(4);
            itensrelatorio.DefaultCell.Border = 0;
            itensrelatorio.WidthPercentage = 100;
            var fontecelula = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12);
            itensrelatorio.AddCell(new Phrase("ID", fontecelula));
            itensrelatorio.AddCell(new Phrase("Nome", fontecelula));
            itensrelatorio.AddCell(new Phrase("quantidade", fontecelula));
            itensrelatorio.AddCell(new Phrase("Valor vendido", fontecelula));
            // id marca, , nome da marca, quantidade, valor
            for (int i = 0; i < lv_relatorio.Items.Count; i++)
            {
                itensrelatorio.AddCell(new Phrase(lv_relatorio.Items[i].SubItems[0].Text, fontecelula));
                itensrelatorio.AddCell(new Phrase(lv_relatorio.Items[i].SubItems[1].Text, fontecelula));
                itensrelatorio.AddCell(new Phrase(lv_relatorio.Items[i].SubItems[2].Text, fontecelula));
                itensrelatorio.AddCell(new Phrase(lv_relatorio.Items[i].SubItems[3].Text, fontecelula));
            }

            itensrelatorio.AddCell(new Phrase("", fontecelula));
            itensrelatorio.AddCell(new Phrase("", fontecelula));
            
            relatorio.Add(itensrelatorio);

            //---------------------------------------------------------------------------------------------//
            var data = DateTime.Today.ToString("dd-MM-yyyy"); // função para pegar a data atual
            //colocar valor total
            PdfPTable informacoes = new PdfPTable(3);
            informacoes.DefaultCell.Border = 0;
            informacoes.WidthPercentage = 100;
            informacoes.AddCell(new Phrase("", fontecelula)); // nome
            informacoes.AddCell(new Phrase("Data: " + data, fontecelula)); // quantidade
            informacoes.AddCell(new Phrase("", fontecelula)); // preço de cada produto

            relatorio.Add(informacoes);
            // -------------------------------------------------------------------------------------------- //
            relatorio.Close();
        }

        private void bt_pdf_Click_1(object sender, EventArgs e)
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

        private void Relatoriomarcaoucategoria_Load(object sender, EventArgs e)
        {

        }

        private void tb_datainicial_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tb_datafinal_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
