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
    public partial class Relatorio_vencimentoprod : Form
    {
        public string dias;
        public Relatorio_vencimentoprod()
        {
            InitializeComponent();
        }

        private void Relatorio_vencimentoprod_Load(object sender, EventArgs e)
        {

        }

        private void check_90dias_CheckedChanged(object sender, EventArgs e)
        {
            if (check_90dias.Checked)
            {
                check_30dias.Enabled = false;
                check_60dias.Enabled = false;
                check_7dias.Enabled = false;
            }
            else
            {
                check_30dias.Enabled = true;
                check_60dias.Enabled = true;
                check_7dias.Enabled = true;
            }
            dias = "90";
        }

        private void check_60dias_CheckedChanged(object sender, EventArgs e)
        {
            if (check_60dias.Checked)
            {
                check_30dias.Enabled = false;
                check_90dias.Enabled = false;
                check_7dias.Enabled = false;
            }
            else
            {
                check_30dias.Enabled = true;
                check_90dias.Enabled = true;
                check_7dias.Enabled = true;
            }
            dias = "60";
        }

        private void check_30dias_CheckedChanged(object sender, EventArgs e)
        {
            if (check_30dias.Checked)
            {
                check_60dias.Enabled = false;
                check_90dias.Enabled = false;
                check_7dias.Enabled = false;
            }
            else
            {
                check_60dias.Enabled = true;
                check_90dias.Enabled = true;
                check_7dias.Enabled = true;
            }
            dias = "30";
        }

        private void check_7dias_CheckedChanged(object sender, EventArgs e)
        {
            if (check_7dias.Checked)
            {
                check_60dias.Enabled = false;
                check_90dias.Enabled = false;
                check_30dias.Enabled = false;
            }
            else
            {
                check_60dias.Enabled = true;
                check_90dias.Enabled = true;
                check_30dias.Enabled = true;
            }
            dias = "7";
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

                if (dias != string.Empty)
                {
                    
                    cmd.Parameters.AddWithValue("@dias", dias);
                    //cmd.Parameters.AddWithValue("@dataatual", DateTime.Today);


                    cmd.CommandText = "select id_fornecedor_produto, nome_produto, lote, datavalidade, (DATEDIFF(DAY, datavalidade, GETDATE())) as 'Dias para vencer', quantidade_produto from fornecedor_produto " +
                    "where (DATEDIFF(DAY, datavalidade, GETDATE())) < @dias " +
                    "order by datavalidade asc";
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
                        //id, nome, lote, datavalidade, dias para vencer, quantidade
                        var lv = new ListViewItem(relatorio.GetInt32(0).ToString()); // id
                        lv.SubItems.Add(relatorio.GetString(1)); // nome 
                        lv.SubItems.Add(relatorio.GetString(2)); //lote
                        lv.SubItems.Add(relatorio.GetDateTime(3).ToString()); // data validade                    
                        lv.SubItems.Add(relatorio.GetInt32(4).ToString()); // dias para vencer                    
                        lv.SubItems.Add(relatorio.GetInt32(5).ToString()); // quantidade                    
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
            titulo.Add("Produtos Próximos ao Vencimento \n\n");
            relatorio.Add(titulo);
            // --------------------------------------------------------------------------------------------//
            PdfPTable itensrelatorio = new PdfPTable(6);
            itensrelatorio.DefaultCell.Border = 0;
            itensrelatorio.WidthPercentage = 100;
            var fontecelula = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12);
            itensrelatorio.AddCell(new Phrase("ID", fontecelula));
            itensrelatorio.AddCell(new Phrase("Nome", fontecelula));
            itensrelatorio.AddCell(new Phrase("Lote", fontecelula));
            itensrelatorio.AddCell(new Phrase("Data de validade", fontecelula));
            itensrelatorio.AddCell(new Phrase("Dias para vencer", fontecelula));
            itensrelatorio.AddCell(new Phrase("Quantidade", fontecelula));
            // id marca, , nome da marca, quantidade, valor
            for (int i = 0; i < lv_relatorio.Items.Count; i++)
            {
                itensrelatorio.AddCell(new Phrase(lv_relatorio.Items[i].SubItems[0].Text, fontecelula));
                itensrelatorio.AddCell(new Phrase(lv_relatorio.Items[i].SubItems[1].Text, fontecelula));
                itensrelatorio.AddCell(new Phrase(lv_relatorio.Items[i].SubItems[2].Text, fontecelula));
                itensrelatorio.AddCell(new Phrase(lv_relatorio.Items[i].SubItems[3].Text, fontecelula));
                itensrelatorio.AddCell(new Phrase(lv_relatorio.Items[i].SubItems[4].Text, fontecelula));
                itensrelatorio.AddCell(new Phrase(lv_relatorio.Items[i].SubItems[5].Text, fontecelula));
            }

            itensrelatorio.AddCell(new Phrase("", fontecelula));
            itensrelatorio.AddCell(new Phrase("", fontecelula));

            relatorio.Add(itensrelatorio);

            //---------------------------------------------------------------------------------------------//
            var data = DateTime.Today.ToString("dd-MM-yyyy"); // função para pegar a data atual

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
    }
}
