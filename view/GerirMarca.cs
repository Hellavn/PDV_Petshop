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
    public partial class GerirMarca : Form
    {
        public int codigo = -1;
        public bool estadomarca = true;
        public GerirMarca()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (lv_marca.SelectedItems.Count == 0)
            {
                // função para alteração do texto conforme for escrevendo no tb
                if (!(tb_nome.Text.Equals("")))
                {
                    CarregarLV();
                }
                else
                {
                    lv_marca.Items.Clear();
                }
            }
        }

        public bool verificarmarca()
        {
            bool existelinha = true;
            try
            {

                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from marca where nome_marca = @nome";
                cmd.Parameters.AddWithValue("@nome", tb_nome.Text);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexao.Conectar();
                SqlDataReader produto = cmd.ExecuteReader();
                if (produto.HasRows)
                {
                    existelinha = false;
                }
                conexao.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
            return existelinha;
        }

        public void CarregarLV()
        {
            lv_marca.LabelEdit = true;
            lv_marca.AllowColumnReorder = true;
            lv_marca.FullRowSelect = true;
            try
            {
                Conexao con = new Conexao();
                SqlCommand cmd = new SqlCommand();
               
                cmd.Parameters.AddWithValue("@nome", tb_nome.Text);
                
                if(cb_inativos.Checked)
                    cmd.CommandText = "select * from marca where nome_marca LIKE '%' + @nome + '%' AND estado_marca = 0";
                else
                    cmd.CommandText = "select * from marca where nome_marca LIKE '%' + @nome + '%' AND estado_marca = 1";

                cmd.CommandType = CommandType.Text;
                cmd.Connection = con.Conectar();
                SqlDataReader marca = cmd.ExecuteReader();
                lv_marca.Items.Clear();
                while (marca.Read())
                {
                    bool estado = marca.GetBoolean(2);
                    var lv = new ListViewItem(marca.GetInt32(0).ToString());
                    lv.SubItems.Add(marca.GetString(1));//nome
                    if(estado == true)
                    {
                        lv.SubItems.Add("Ativado"); //estado
                    }
                    else
                    {
                        lv.SubItems.Add("Desativado");
                    }
                    lv_marca.Items.Add(lv);
                }
                con.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if (tb_nome.Text != string.Empty && codigo == -1)
            {
                if (verificarmarca())
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja cadastrar categoria?", "ALERTA", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        CRUDMarca cad = new CRUDMarca(codigo, tb_nome.Text, estadomarca);
                        cad.cadastrar_marca();
                        MessageBox.Show(cad.exibir_mensagem);
                    }
                }
                else
                {
                    MessageBox.Show("Marca já existente");
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Você selecionou um produto já existente. \n Deseja Cadastrar novo produto?", "ALERTA", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    tb_nome.Text = "";
                    codigo = -1;
                }
            }
        }

        private void lv_marca_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(lv_marca.SelectedItems[0].SubItems[2].Text);

            codigo = int.Parse(lv_marca.SelectedItems[0].SubItems[0].Text);
            string estadom = lv_marca.SelectedItems[0].SubItems[2].Text;
            tb_nome.Text = lv_marca.SelectedItems[0].SubItems[1].Text;
            if (estadom.Equals("Ativado")) 
            { 
                estadomarca = true;
            }
            else
            {
                estadomarca = false;
            }
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            if (!(codigo == -1))
            {
                DialogResult dialogResult = MessageBox.Show("Deseja editar marca?", "ALERTA", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CRUDMarca cad = new CRUDMarca(codigo, tb_nome.Text, estadomarca);
                    cad.editar_marca();
                    MessageBox.Show(cad.exibir_mensagem);
                    tb_nome.Text = "";
                    codigo = -1;
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Marca não existente. Deseja cadastrar nova?");
                if (dialogResult == DialogResult.Yes)
                {
                    codigo = -1;
                }
            }
        }

        private void bt_dstv_Click(object sender, EventArgs e)
        {
            if (!(codigo == -1))
            {
                DialogResult dialogResult = MessageBox.Show("Deseja desativar marca? \n", "ALERTA", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CRUDMarca cad = new CRUDMarca(codigo, tb_nome.Text, estadomarca);
                    cad.excluir_marca();
                    MessageBox.Show(cad.exibir_mensagem);
                    tb_nome.Text = "";
                    codigo = -1;
                }
                else
                {
                    MessageBox.Show("Operação cancelada");
                    tb_nome.Text = "";
                }
            }
            else
            {
                MessageBox.Show("A marca que está tentando editar não existe.");
            }
        }

        private void cb_inativos_CheckedChanged(object sender, EventArgs e)
        {
            CarregarLV();
        }

        private void lv_marca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbnome_Click(object sender, EventArgs e)
        {

        }
    }
}
