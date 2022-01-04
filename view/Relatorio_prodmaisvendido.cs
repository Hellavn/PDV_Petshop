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
    public partial class Relatorio_prodmaisvendido : Form
    {
        public double valortotal = 0;
       
        public Relatorio_prodmaisvendido()
        {
            InitializeComponent();
            carregarCB_categoria();
            carregarCB_marca();
            cal_inicial.MaxDate = DateTime.Today;
            cal_final.MaxDate = DateTime.Today;
        }

        public void carregarCB_categoria()
        {
            try
            {
                Conexao con = new Conexao();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from categoria where estado_categoria = 1";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con.Conectar();

                SqlDataReader categoria = cmd.ExecuteReader();
                cb_categoria.Items.Clear();
                while (categoria.Read())
                {
                    cb_categoria.Items.Add(categoria.GetString(1));
                }
                con.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
        }

        public void carregarCB_marca()
        {
            try
            {
                Conexao con = new Conexao();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from marca where estado_marca = 1";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con.Conectar();

                SqlDataReader marca = cmd.ExecuteReader();
                cb_marca.Items.Clear();
                while (marca.Read())
                {
                    cb_marca.Items.Add(marca.GetString(1));
                }
                con.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
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
            PdfPTable itensrelatorio = new PdfPTable(4);
            itensrelatorio.DefaultCell.Border = 0;
            itensrelatorio.WidthPercentage = 100;
            var fontecelula = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12);
            itensrelatorio.AddCell(new Phrase("ID", fontecelula));
            itensrelatorio.AddCell(new Phrase("Quantidade", fontecelula));
            itensrelatorio.AddCell(new Phrase("Nome", fontecelula));
            itensrelatorio.AddCell(new Phrase("Valor vendido", fontecelula));

            for (int i = 0; i < lv_relatorio.Items.Count; i++)
            {
                itensrelatorio.AddCell(new Phrase(lv_relatorio.Items[i].SubItems[0].Text, fontecelula));
                itensrelatorio.AddCell(new Phrase(lv_relatorio.Items[i].SubItems[1].Text, fontecelula));
                itensrelatorio.AddCell(new Phrase(lv_relatorio.Items[i].SubItems[2].Text, fontecelula));
                itensrelatorio.AddCell(new Phrase(lv_relatorio.Items[i].SubItems[3].Text, fontecelula));
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
            informacoesvenda.AddCell(new Phrase("Valor total: R$ " + valortotal.ToString("F2"), fontecelula));  // nome
            informacoesvenda.AddCell(new Phrase("Data: " + data, fontecelula)); // quantidade
            informacoesvenda.AddCell(new Phrase("", fontecelula)); // preço de cada produto

            relatorio.Add(informacoesvenda);
            // -------------------------------------------------------------------------------------------- //
            relatorio.Close();
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
                valortotal = 0;
                bool pesquisa = false;
                cmd.Parameters.AddWithValue("@datainicial", cal_inicial.SelectionStart);
                cmd.Parameters.AddWithValue("@datafinal", cal_final.SelectionStart);
    

                if (cb_marca.Text != string.Empty && cb_categoria.Text == string.Empty)
                {
                    //DateTime datainicial = tb_datainicial.Text;
                    
                    cmd.Parameters.AddWithValue("@marca", cb_marca.Text);
                    
                    cmd.CommandText = "SELECT i.id_produto, COUNT(i.id_produto) as quantidade_produto, " +
                        "i.nome_produto, SUM(i.valor_total_itens) as 'Valor vendido' "+
                        "FROM itens as i " +
                        "INNER JOIN produto as P on i.id_produto = p.id_produto " +
                        "where p.marca = @marca and data_venda between @datainicial AND @datafinal " +
                        "GROUP BY i.id_produto, i.nome_produto "+
                        "ORDER BY quantidade_produto DESC";
                        pesquisa = true;
                }

                if (cb_marca.Text == string.Empty && cb_categoria.Text != string.Empty)
                {
                    //DateTime datainicial = tb_datainicial.Text;
                   
                    cmd.Parameters.AddWithValue("@categoria", cb_categoria.Text);

                    cmd.CommandText = "SELECT i.id_produto, COUNT(i.id_produto) as quantidade_produto, " +
                        "i.nome_produto, SUM(i.valor_total_itens) as 'Valor vendido' " +
                        "FROM itens as i " +
                        "INNER JOIN produto as P on i.id_produto = p.id_produto " +
                        "where p.categoria = @categoria and data_venda between @datainicial AND @datafinal " +
                        "GROUP BY i.id_produto, i.nome_produto " +
                        "ORDER BY quantidade_produto DESC";
                        pesquisa = true;
                }

                if (cb_marca.Text != string.Empty && cb_categoria.Text != string.Empty)
                {
                    //DateTime datainicial = tb_datainicial.Text;

                    cmd.Parameters.AddWithValue("@categoria", cb_categoria.Text);
                    cmd.Parameters.AddWithValue("@marca", cb_marca.Text);
                    cmd.CommandText = "SELECT i.id_produto, COUNT(i.id_produto) as quantidade_produto, " +
                        "i.nome_produto, SUM(i.valor_total_itens) as 'Valor vendido' " +
                        "FROM itens as i " +
                        "INNER JOIN produto as P on i.id_produto = p.id_produto " +
                        "where p.marca = @marca AND p.categoria = @categoria and data_venda between @datainicial AND @datafinal " +
                        "GROUP BY i.id_produto, i.nome_produto " +
                        "ORDER BY quantidade_produto DESC";
                    pesquisa = true;
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
                        lv.SubItems.Add(relatorio.GetInt32(1).ToString()); // quantidade                    
                        lv.SubItems.Add(relatorio.GetString(2));
                        lv.SubItems.Add(relatorio.GetDouble(3).ToString("F2"));
                        valortotal = valortotal + Double.Parse(relatorio.GetDouble(3).ToString("F2")); 

                        lv_relatorio.Items.Add(lv);
                    }
                    con.Desconectar();
                }
                else
                {
                    MessageBox.Show("Favor selecionar filtros de pesquisa.");
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
            MessageBox.Show("Relatório gerado");
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
        private void Relatorio_prodmaisvendido_Load(object sender, EventArgs e)
        {

        }
    }
}
