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
    public partial class Relatorio_produtocombaixoestoque : Form
    {
        public Relatorio_produtocombaixoestoque()
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
                
                cmd.CommandText = "select e.id_fornecedor_produto, e.nome_produto, e.nome_fornecedor, e.quantidade_produto, p.marca from fornecedor_produto as e " +
                                   "inner join produto as p on e.id_produto = p.id_produto " +
                                   "where e.quantidade_produto < 30 "+
                                    "order by quantidade_produto asc";
                pesquisa = true;
                
                if (pesquisa)
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con.Conectar();
                    SqlDataReader relatorio = cmd.ExecuteReader();
                    lv_relatorio.Items.Clear();
                    while (relatorio.Read())
                    {

                        // id_fornecedor_produto, nome produto, fornecedor, quantidade, marca
                        var lv = new ListViewItem(relatorio.GetInt32(0).ToString()); // id
                        lv.SubItems.Add(relatorio.GetString(1)); //nome produto
                        lv.SubItems.Add(relatorio.GetString(2)); // nome fornecedor
                        lv.SubItems.Add(relatorio.GetInt32(3).ToString()); // quantidade                    
                        lv.SubItems.Add(relatorio.GetString(2)); //marca
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
            nomeempresa.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 7);
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
            titulo.Add("Produtos mais vendidos \n\n");
            relatorio.Add(titulo);
            // --------------------------------------------------------------------------------------------//
            PdfPTable itensrelatorio = new PdfPTable(5);
            // id_fornecedor_produto, nome produto, fornecedor, quantidade, marca
            itensrelatorio.DefaultCell.Border = 0;
            itensrelatorio.WidthPercentage = 100;
            var fontecelula = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12);
            itensrelatorio.AddCell(new Phrase("ID", fontecelula));
            itensrelatorio.AddCell(new Phrase("Produto", fontecelula));
            itensrelatorio.AddCell(new Phrase("Fornecedor", fontecelula));
            itensrelatorio.AddCell(new Phrase("Quantidade", fontecelula));
            itensrelatorio.AddCell(new Phrase("Marca", fontecelula));
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
            //itensvenda.AddCell(new Phrase("Total:     R$ " + lb_valortotal.Text, fontecelula));
            relatorio.Add(itensrelatorio);

            //---------------------------------------------------------------------------------------------//
            var data = DateTime.Today.ToString("dd-MM-yyyy"); // função para pegar a data atual

            PdfPTable informacoesvenda = new PdfPTable(3);
            informacoesvenda.DefaultCell.Border = 0;
            informacoesvenda.WidthPercentage = 100;
            informacoesvenda.AddCell(new Phrase("", fontecelula)); // nome
            informacoesvenda.AddCell(new Phrase("Data: " + data, fontecelula)); // quantidade
            informacoesvenda.AddCell(new Phrase("", fontecelula)); // preço de cada produto

            relatorio.Add(informacoesvenda);
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
    }
}
