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
    public partial class backupBusca : Form
    {
        public Estoque telaestoque;
        public MargemLucro telamargem;
        public bool entraestoque = false;
        public bool entramargem=false;
        public backupBusca(Estoque est)
        {
            InitializeComponent();
            telaestoque = est;
            entraestoque = true;
        }

        public backupBusca(MargemLucro ml)
        {
            InitializeComponent();
            telamargem = ml;
            entramargem = true;
        }

        // evento de mudança de nome
        private void tb_nome_TextChanged(object sender, EventArgs e)
        {
            // ação feita no botão nome enquanto é escrito texto nele
            if (!(tb_nome.Text.Equals("")))
            {
                CarregarLV();
            }
            //caso não entre no if, limpar listview
        }

        public void CarregarLV()
        {
            lv_pesquisa.LabelEdit = true;
            lv_pesquisa.AllowColumnReorder = true;
            lv_pesquisa.FullRowSelect = true;
            try
            {
                Conexao con = new Conexao();
                SqlCommand cmd = new SqlCommand();
                   
                //estado, categoria, marca
                cmd.Parameters.AddWithValue("@nomeproduto", tb_nome.Text);
                cmd.CommandText = "select * from produto where nome_produto LIKE '%' + @nomeproduto + '%' AND estado_produto = 1";

                cmd.CommandType = CommandType.Text;
                cmd.Connection = con.Conectar();
                SqlDataReader produto = cmd.ExecuteReader();
                lv_pesquisa.Items.Clear();
                while (produto.Read())
                {
                    // tabela fornecedor_produto id_produto (1), nome_produto(7), marca(9), cateogria(10), 
                    // tabela produto estado(7)
                    //id, nome , marca, categoria, estado
                    var lv = new ListViewItem(produto.GetInt32(0).ToString());      //id
                    lv.SubItems.Add(produto.GetString(1));                          // nome
                    lv.SubItems.Add(produto.GetString(3));                          // marca
                    lv.SubItems.Add(produto.GetString(3));                          // categoria
                    lv_pesquisa.Items.Add(lv);
                }
                con.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
        }
       
        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            if (entraestoque)
            {
                telaestoque.codigo = int.Parse(lv_pesquisa.SelectedItems[0].SubItems[0].Text);
                this.Close();
            }
            if (entramargem)
            {
                telamargem.codigo = int.Parse(lv_pesquisa.SelectedItems[0].SubItems[0].Text);
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_pesquisar_Click_1(object sender, EventArgs e)
        {
            if (entraestoque)
            {
                telaestoque.codigo = int.Parse(lv_pesquisa.SelectedItems[0].SubItems[0].Text);
                this.Close();
            }
            if (entramargem)
            {
                telamargem.codigo = int.Parse(lv_pesquisa.SelectedItems[0].SubItems[0].Text);
                this.Close();
            }
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
    }
}
