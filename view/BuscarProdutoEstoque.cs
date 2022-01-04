using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Petshop.view
{
    public partial class BuscarProdutoEstoque : Form
    {
        public String exibir_mensagem = "";
        public int id_marca = 0;
        public int id_categoria = 0;
        public string nome_marca = "";
        public string nome_categoria = "";
        public TelaDeCaixa telacaixa;
        public bool entracaixa = false;
        

        public BuscarProdutoEstoque()
        {
            InitializeComponent();
           
        }
       
        public BuscarProdutoEstoque(TelaDeCaixa tc)
        {
            InitializeComponent();
            telacaixa = tc;
            entracaixa = true;
        }

       /*
        public BuscarProdutoEstoque(Estoque est)
        {
            InitializeComponent();
            telaestoque = est;
            entraestoque = true;
        }
       */
        public void CarregarLV()
        {
            lv_pesquisa.LabelEdit = true;
            lv_pesquisa.AllowColumnReorder = true;
            lv_pesquisa.FullRowSelect = true;
            try
            {
                Conexao con = new Conexao();
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@nomeproduto", tb_nome.Text);
                cmd.Parameters.AddWithValue("@nomefornecedor", tbFornecedor.Text);
                cmd.Parameters.AddWithValue("@lote", tbLote.Text);

                cmd.CommandText = "select * from fornecedor_produto where nome_produto LIKE '%' + @nomeproduto + '%' AND " +
                                                 "lote LIKE '%' + @lote + '%' AND " +
                                                 "nome_fornecedor LIKE '%' + @nomefornecedor + '%'";

              
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con.Conectar();
                SqlDataReader produto = cmd.ExecuteReader();
                lv_pesquisa.Items.Clear();
                while (produto.Read())
                {
                    //id, nome , marca, categoria, estado
                    // tabela fornecedor_produto id_produto (1), nome_produto(7), marca(9), cateogria(10), 
                    // tabela produto estado(7)
                    var lv = new ListViewItem(produto.GetInt32(1).ToString());  //id
                    lv.SubItems.Add(produto.GetString(7));                      // nome          
                    lv.SubItems.Add(produto.GetString(8));                      // fornecedor
                    lv.SubItems.Add(produto.GetString(3));                      //lote
                    lv_pesquisa.Items.Add(lv);
                }
                con.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
        }
        private void tb_nome_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void lv_pesquisa_MouseClick(object sender, MouseEventArgs e)
        {
            //id_marca = int.Parse(lv_pesquisa.SelectedItems[0].SubItems[2].Text);
            //carregarCB_marca();
        }

        private void tbFornecedor_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void tbLote_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
         
            
        }

        private void tb_nome_TextChanged_1(object sender, EventArgs e)
        {
            // ação feita no botão nome enquanto é escrito texto nele
            if (!(tb_nome.Text.Equals("")))
            {
                CarregarLV();
            }
            //caso não entre no if, limpar listview
        }

        private void tbFornecedor_TextChanged_1(object sender, EventArgs e)
        {
            if (!(tbFornecedor.Text.Equals("")))
            {
                CarregarLV();
            }
        }

        private void tbLote_TextChanged_1(object sender, EventArgs e)
        {
            if (!(tbLote.Text.Equals("")))
            {
                CarregarLV();
            }
        }

        private void bt_pesquisar_Click_1(object sender, EventArgs e)
        {
            if (entracaixa)
            {
                telacaixa.codigo = int.Parse(lv_pesquisa.SelectedItems[0].SubItems[0].Text);
                telacaixa.blote = (lv_pesquisa.SelectedItems[0].SubItems[3].Text);
                telacaixa.bfornecedor = (lv_pesquisa.SelectedItems[0].SubItems[2].Text);
                this.Close();
            }
            /*
            if (entraestoque)
            {
                telaestoque.codigo = int.Parse(lv_pesquisa.SelectedItems[0].SubItems[0].Text);
                this.Close();
            }
            */
        }
    }
}