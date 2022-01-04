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
    public partial class GerirProduto : Form
    {
        public int codigo = -1;
        public string id_marca;
        public string id_categoria;
        public GerirProduto()
        {
            InitializeComponent();
        }
        private void GerirProduto_Load(object sender, EventArgs e)
        {
            carregarCB_categoria();
            carregarCB_marca();
            //CarregarListView();
            //TextBox_precoproduto.Text = "00.00";
        }
        private void listView_produto_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }


        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;

            try
            {
                //textBox2.Text = "R$ " + string.Format("{0:C2}", v);
                //textBox2.Text = string.Format("{0:C2}", v);
                
                n = txt.Text.Replace("R$ ", "").Replace(",", "").Replace(".", "");
               
                if (n.Equals(""))
                    n = ""; 
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                //"{0:$#,##0.00;($#,##0.00);Zero}"
                txt.Text = string.Format("{0:C2}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }
        }
        public void CarregarListView()
        {
            listView_produto.LabelEdit = true;
            listView_produto.AllowColumnReorder = true;
            listView_produto.FullRowSelect = true;
            try
            {
                Conexao con = new Conexao();
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@nomeproduto", textBox_nomeproduto.Text);

                if (checkB_estado.Checked)
                {
                   cmd.CommandText = "select * from produto where nome_produto LIKE '%' + @nomeproduto + '%' AND estado_produto = '0'";
                }
                else
                {
                    cmd.CommandText = "select * from produto where nome_produto LIKE '%' + @nomeproduto + '%' AND estado_produto = '1'";
                }

                cmd.CommandType = CommandType.Text;
                cmd.Connection = con.Conectar();

                SqlDataReader produto = cmd.ExecuteReader();
                listView_produto.Items.Clear();
                while (produto.Read())
                {
                    var lv = new ListViewItem(produto.GetInt32(0).ToString());
                    lv.SubItems.Add(produto.GetString(1));
                    lv.SubItems.Add(produto.GetDouble(2).ToString("F2")); //valor
                    lv.SubItems.Add(produto.GetString(3));
                    lv.SubItems.Add(produto.GetString(4));

                    bool estado = produto.GetBoolean(7);

                    if (estado == true)
                    {
                        lv.SubItems.Add("Ativado");
                    }
                    else
                    {
                        lv.SubItems.Add("Desativado");
                    }
                    
                    lv.SubItems.Add(produto.GetDouble(8).ToString("F2"));//preco de compra
                    listView_produto.Items.Add(lv);
                }
                con.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
        }

        public void Limpar()
        {
            foreach (Control c in this.Controls)
            {

                if (c is TextBox)
                    ((TextBox)c).Text = string.Empty;
                if (c is CheckBox)
                    ((CheckBox)c).Checked = false;
                if (c is MaskedTextBox)
                    ((MaskedTextBox)c).Text = string.Empty;
                if (c is ComboBox)
                    ((ComboBox)c).Text = string.Empty;
                TextBox_precoproduto.Text = "00.00";
                tbPrecoCompra.Text = "00.00";
            }
        }

        // Carregar fornecedores cadastrados no cb de selecionar fornecedor do produto  
        public void carregarCB_categoria()
        {
            try
            {
                Conexao con = new Conexao();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from categoria where estado_categoria = 1";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con.Conectar();

                SqlDataReader produto = cmd.ExecuteReader();
                comboBox_categoria.Items.Clear();
                while (produto.Read())
                {
                    comboBox_categoria.Items.Add(produto.GetInt32(0).ToString() + " - " + produto.GetString(1));
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

                SqlDataReader fornecedor = cmd.ExecuteReader();
                comboBox_marca.Items.Clear();
                while (fornecedor.Read())
                {
                    comboBox_marca.Items.Add(fornecedor.GetInt32(0).ToString() + " - " + fornecedor.GetString(1));
                }
                con.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
        }

        private void TextBox_precoproduto_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref TextBox_precoproduto);
        }

        private void comboBox_fornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_precoproduto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void button_cadprod_Click(object sender, EventArgs e)
        {

            if (!(textBox_nomeproduto.Text == string.Empty || TextBox_precoproduto.Text == string.Empty || comboBox_categoria.Text == string.Empty || comboBox_marca.Text == string.Empty || tbPrecoCompra.Text == string.Empty))
            {
                if (codigo == -1)
                {
                    //(preco_produto - preco_compra) / preco_compra)
                    
                    string cbMarca = "";
                    if(comboBox_marca.Text.Contains(" - "))
                    {
                        string[] marca = comboBox_marca.Text.Split(" - ");
                        cbMarca = marca[1];
                        id_marca = marca[0];
                    }
                    else
                    {
                        cbMarca = comboBox_marca.Text;
                        
                    }

                    string cbCategoria = "";
                    if (comboBox_marca.Text.Contains(" - "))
                    {
                        string[] categoria = comboBox_categoria.Text.Split(" - ");
                        cbCategoria = categoria[1];
                        id_categoria = categoria[0];
                    }
                    else
                    {
                        cbCategoria = comboBox_categoria.Text;
                    }
                    string[] valor = TextBox_precoproduto.Text.Split("R$");
                    string[] precocompra = tbPrecoCompra.Text.Split("R$");
                    double margemlucro = ((double.Parse(valor[1]) - double.Parse(precocompra[1]) / double.Parse(precocompra[1])) * 100); 
                    CRUDproduto cad = new CRUDproduto(codigo, textBox_nomeproduto.Text, float.Parse(valor[1]), cbMarca, cbCategoria, id_marca, id_categoria, cbEstadoProd.Text, float.Parse(precocompra[1]), margemlucro);
                    cad.cadastrar_produto();
                    MessageBox.Show(cad.exibir_mensagem);
                    CarregarListView();
                    Limpar();
                    codigo = -1;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Você selecionou um produto já existente. \n Deseja Cadastrar novo produto?", "ALERTA", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Limpar();
                        codigo = -1;
                    }
                }
            }
            else
            {
                MessageBox.Show("Favor preencher todos os campos");
            }
        }

        private void button_editarprod_Click(object sender, EventArgs e)
        {
            string[] precocompra = tbPrecoCompra.Text.Split("R$");
            string[] valor = TextBox_precoproduto.Text.Split("R$");
            double margemlucro = ((double.Parse(valor[1]) - double.Parse(precocompra[1]) / double.Parse(precocompra[1]))*100);
            if (!(textBox_nomeproduto.Text == string.Empty || TextBox_precoproduto.Text == string.Empty || comboBox_categoria.Text == string.Empty || comboBox_marca.Text == string.Empty))
            {

                string cbMarca = "";
                if (comboBox_marca.Text.Contains(" - "))
                {
                    string[] marca = comboBox_marca.Text.Split(" - ");
                    cbMarca = marca[1];
                    id_marca = marca[0];
                }
                else
                {
                    cbMarca = comboBox_marca.Text;

                }

                string cbCategoria = "";
                if (comboBox_marca.Text.Contains(" - "))
                {
                    string[] categoria = comboBox_categoria.Text.Split(" - ");
                    cbCategoria = categoria[1];
                    id_categoria = categoria[0];
                }
                else
                {
                    cbCategoria = comboBox_categoria.Text;
                }
                CRUDproduto cad = new CRUDproduto(codigo, textBox_nomeproduto.Text, float.Parse(valor[1]), cbMarca, cbCategoria, id_marca, id_categoria, cbEstadoProd.Text, float.Parse(precocompra[1]), margemlucro);

                if (!(codigo == -1))
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja editar produto?", "ALERTA", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cad.editar_produto();
                        MessageBox.Show(cad.exibir_mensagem);
                        CarregarListView();
                        Limpar();
                        codigo = -1;
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Esse produto não existente. " +
                                                            "\n Desejesa Cadastratrar novo produto?", "ALERTA", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Limpar();
                        codigo = -1;
                    }
                }
            }
            else
            {
                MessageBox.Show("Favor preencher corretamente o(s) campo(s) que deseja cadastrar.");
            }
        }

        private void button_excluirpro_Click(object sender, EventArgs e)
        {
            if (!(codigo == -1))
            {
                DialogResult dialogResult = MessageBox.Show("Deseja excluir produto? \n Essa ação não pode ser revertida.", "ALERTA", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string cbMarca = "";
                    if (comboBox_marca.Text.Contains(" - "))
                    {
                        string[] marca = comboBox_marca.Text.Split(" - ");
                        cbMarca = marca[1];
                        id_marca = marca[0];
                    }
                    else
                    {
                        cbMarca = comboBox_marca.Text;

                    }

                    string cbCategoria = "";
                    if (comboBox_marca.Text.Contains(" - "))
                    {
                        string[] categoria = comboBox_categoria.Text.Split(" - ");
                        cbCategoria = categoria[1];
                        id_categoria = categoria[0];
                    }
                    else
                    {
                        cbCategoria = comboBox_categoria.Text;
                    }

                    string[] precocompra = tbPrecoCompra.Text.Split("R$");
                    string[] valor = TextBox_precoproduto.Text.Split("R$");
                    double margemlucro = ((double.Parse(valor[1]) - double.Parse(precocompra[1]) / double.Parse(precocompra[1])) * 100);
                    CRUDproduto cad = new CRUDproduto(codigo, textBox_nomeproduto.Text, float.Parse(valor[1]), cbMarca, cbCategoria, id_marca, id_categoria, cbEstadoProd.Text, float.Parse(precocompra[1]), margemlucro);
                    cad.excluir_produto();
                    MessageBox.Show(cad.exibir_mensagem);
                    CarregarListView();
                    Limpar();
                    codigo = -1;
                }
                else
                {
                    MessageBox.Show("Operação cancelada");
                    Limpar();
                }
            }
            else
            {
                MessageBox.Show("O produto que está tentando excluir não existe.");
            }
        }

        private void tbPrecoCompra_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref tbPrecoCompra);
        }

        private void textBox_nomeproduto_TextChanged(object sender, EventArgs e)
        {
            //buscar conforme a escrita
            if (!(textBox_nomeproduto.Text.Equals("")))
            {
                if (listView_produto.SelectedItems.Count == 0) 
                {
                    CarregarListView();
                }
            }
        }

        private void listView_produto_MouseClick(object sender, MouseEventArgs e)
        {
            codigo = int.Parse(listView_produto.SelectedItems[0].SubItems[0].Text);
            textBox_nomeproduto.Text = listView_produto.SelectedItems[0].SubItems[1].Text;
            TextBox_precoproduto.Text = "R$ " + listView_produto.SelectedItems[0].SubItems[2].Text;
            comboBox_marca.Text = listView_produto.SelectedItems[0].SubItems[3].Text;
            comboBox_categoria.Text = listView_produto.SelectedItems[0].SubItems[4].Text;
            cbEstadoProd.Text = listView_produto.SelectedItems[0].SubItems[5].Text;
            tbPrecoCompra.Text = listView_produto.SelectedItems[0].SubItems[6].Text;   
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkB_estado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkB_estado.Checked)
            {
                CarregarListView();
                textBox_nomeproduto.Text = String.Empty;
            }
            else
            {
                CarregarListView();
                textBox_nomeproduto.Text = String.Empty;
            }
        }
    }
}
