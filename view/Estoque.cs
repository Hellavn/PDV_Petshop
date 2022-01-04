using Projeto_Petshop.view;
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

namespace Projeto_Petshop
{
    public partial class Estoque : Form
    {
        public int qtdAtual = 0;
        public int idproduto = -1;
        public int codigo = 0;
        public Estoque()
        {
            InitializeComponent();
            tbPrecoCompra.Text = " R$ 00.00";
            CarregarCB_Fornecedor();
            CarregarCB_lote();
            calendario_fabricacao.MaxDate = DateTime.Today;
            calendario_validade.MinDate = DateTime.Today;
        }

        public Estoque(BuscarProdutoEstoque buscar)
        {
            InitializeComponent();
            tbPrecoCompra.Text = " R$ 00.00";
            CarregarCB_Fornecedor();
            CarregarCB_lote();
            calendario_fabricacao.MaxDate = DateTime.Today;
            calendario_validade.MaxDate = DateTime.Today;
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
                cmd.Parameters.AddWithValue("@cod", codigo);

                cmd.CommandText = "select * from fornecedor_produto where id_produto = @cod";
                cmd.CommandType = CommandType.Text;
                
                cmd.Connection = con.Conectar();
                listView_produto.Items.Clear();
                SqlDataReader produto = cmd.ExecuteReader();
                while (produto.Read())
                {
                    var lv = new ListViewItem(produto.GetInt32(0).ToString());
                    lv.SubItems.Add(produto.GetInt32(1).ToString());
                    lv.SubItems.Add(produto.GetInt32(2).ToString());
                    lv.SubItems.Add(produto.GetString(7));
                    lv.SubItems.Add(produto.GetString(3));
                    lv.SubItems.Add(produto.GetString(8));
                    lv.SubItems.Add(produto.GetInt32(4).ToString());
                    lv.SubItems.Add(produto.GetDouble(12).ToString("F2"));
                    lv.SubItems.Add(produto.GetDouble(11).ToString("F2"));
                    listView_produto.Items.Add(lv);
                }
                con.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void realizarBusca()
        {
            try
            {
                Conexao con = new Conexao();

                SqlCommand cmd = new SqlCommand();
                codigo = int.Parse(textBox_codigoprod.Text);
                cmd.Parameters.AddWithValue("@cod", codigo);

                cmd.CommandText = "select * from produto where id_produto = @cod";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con.Conectar();

                SqlDataReader produto = cmd.ExecuteReader();
                comboBox_lote.Items.Clear();
                label_nome.Text = "";
                while (produto.Read())
                {
                    label_nome.Text = produto.GetString(1);
                    label_marca.Text = produto.GetString(3);
                    lb_precoproduto.Text = (produto.GetDouble(2).ToString("F2"));
                }
                con.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
            CarregarCB_lote();
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            // botão de busca
            // fazer array com os lotes disponiveis
            if (textBox_codigoprod.Text != string.Empty)
            {
                realizarBusca();
                
            }
            else
            {
                backupBusca buscar = new backupBusca(this);
                buscar.ShowDialog();
                textBox_codigoprod.Text = codigo.ToString();
                realizarBusca();
            }
            CarregarListView();

        }


        public void CarregarCB_Fornecedor()
        {
            try
            {
                Conexao con = new Conexao();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from fornecedor";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con.Conectar();

                SqlDataReader fornecedor = cmd.ExecuteReader();
                comboBox_fornecedor.Items.Clear();
                while (fornecedor.Read())
                {
                    comboBox_fornecedor.Items.Add(fornecedor.GetInt32(0).ToString() + " - " + fornecedor.GetString(1));
                }
                con.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao se conectar ao banco de dados");
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
                if (c is ComboBox)
                    ((ComboBox)c).Text = string.Empty;
                label_marca.Text = string.Empty;
                label_nome.Text = string.Empty;
                tbPrecoCompra.Text = "R$ 00.00";
                
            }
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
                MessageBox.Show("Erro moeda");
            }
        }

        private void Estoque_Load(object sender, EventArgs e)
        {

            
        }

        public void CarregarCB_lote()
        {
            // fazer array com os lotes disponiveis
            try
            {
                Conexao con = new Conexao();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from fornecedor_produto";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con.Conectar();

                SqlDataReader lote = cmd.ExecuteReader();
                comboBox_lote.Items.Clear();
                while (lote.Read())
                {
                    comboBox_lote.Items.Add(lote.GetString(3));
                }
                con.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            ManterQuantidadeAtual();

            DialogResult dialogResult = MessageBox.Show("Deseja adicionar itens de estoque?", "ALERTA", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string[] verificarvalor = tbPrecoCompra.Text.Split("R$");

                if (double.Parse(verificarvalor[1]) == 0)
                {
                    MessageBox.Show("Favor informar o valor de pago no produto");
                }
                else
                {
                    if (idproduto == -1)
                    {

                        if (comboBox_fornecedor.Text != string.Empty)
                        {
                            string valor = lb_precoproduto.Text;
                            string[] precocompra = tbPrecoCompra.Text.Split("R$");
                            string[] fornecedor = comboBox_fornecedor.Text.Split(" - ");
                            DateTime fabricacao = calendario_fabricacao.SelectionStart;
                            DateTime validade = calendario_validade.SelectionStart;
                            //resolvido
                            // agora corrigir o erro ao passar da listview para os lb/tb puta

                            ControleEstoque add = new ControleEstoque(int.Parse(textBox_codigoprod.Text), int.Parse(fornecedor[0]), fornecedor[1], label_nome.Text, comboBox_lote.Text, int.Parse(textBox_qtdprod.Text), fabricacao, validade, valor, precocompra[1]);
                            add.inserirNovo();
                            MessageBox.Show(add.exibir_mensagem);
                            Limpar();
                        }
                        else
                        {
                            MessageBox.Show("Favor informar fornecedor.");
                        }
                    }
                    else
                    {
                        if (comboBox_fornecedor.Text != string.Empty)
                        {
                            string valor = lb_precoproduto.Text;
                            //string[] valor = lb_precoproduto.Text.Split("R$ ");
                            string[] precocompra = tbPrecoCompra.Text.Split("R$");
                            qtdAtual = qtdAtual + int.Parse(textBox_qtdprod.Text);
                            string[] fornecedor = comboBox_fornecedor.Text.Split("-");
                            DateTime fabricacao = calendario_fabricacao.SelectionStart;
                            DateTime validade = calendario_validade.SelectionStart;
                            //tem erro pra corrijir aqui
                            ControleEstoque add = new ControleEstoque(int.Parse(textBox_codigoprod.Text), int.Parse(fornecedor[0]), fornecedor[1], label_nome.Text, comboBox_lote.Text, qtdAtual, fabricacao, validade, valor, precocompra[1]);
                            add.Movimentar();
                            MessageBox.Show(add.exibir_mensagem);
                            Limpar();
                        }
                    }
                }

               
            }
            //CarregarListView();
        }

        void ManterQuantidadeAtual(){
            {   
                try
                {
                    Conexao con = new Conexao();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select id_fornecedor_produto, quantidade_produto from fornecedor_produto" +
                        " where lote = @lote and id_produto = @id_produto and id_fornecedor = @id_fornecedor";

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con.Conectar();
                    
                    string[] fornecedor = comboBox_fornecedor.Text.Split(" - ");
                    cmd.Parameters.AddWithValue("@lote", comboBox_lote.Text);
                    cmd.Parameters.AddWithValue("@id_produto", int.Parse(textBox_codigoprod.Text));
                    cmd.Parameters.AddWithValue("@id_fornecedor", int.Parse(fornecedor[0]));
                    
                    SqlDataReader quantidade = cmd.ExecuteReader();
                    while (quantidade.Read())
                    {
                        idproduto = quantidade.GetInt32(0);
                        qtdAtual = quantidade.GetInt32(1);
                    }
                    con.Desconectar();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Tentar realizar operação novamentem, erro ao recuperar quantidade atual. ");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManterQuantidadeAtual();

            DialogResult dialogResult = MessageBox.Show("Deseja remover itens de estoque?", "ALERTA", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            { 

                if (qtdAtual > 0 & idproduto != -1)
                {
                    string valor = lb_precoproduto.Text;
                    string[] precocompra = tbPrecoCompra.Text.Split("R$");
                    try
                    {
                        qtdAtual = qtdAtual - int.Parse(textBox_qtdprod.Text);
                        string[] fornecedor = comboBox_fornecedor.Text.Split(" - ");
                        DateTime fabricacao = calendario_fabricacao.SelectionStart;
                        DateTime validade = calendario_validade.SelectionStart;
                        
                        ControleEstoque add = new ControleEstoque(int.Parse(textBox_codigoprod.Text), int.Parse(fornecedor[0]), fornecedor[1], label_nome.Text, comboBox_lote.Text, qtdAtual, fabricacao, validade, valor, precocompra[1]);
                        add.Movimentar();
                        MessageBox.Show(add.exibir_mensagem);
                        Limpar();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Impossivel realizar a operação");
                    }
                }
            }
            else
            {
                MessageBox.Show("Impossivel realizar a operação.");
            }

            CarregarListView();
        }

        private void listView_produto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView_produto_MouseClick(object sender, MouseEventArgs e)
        {
            idproduto = int.Parse(listView_produto.SelectedItems[0].SubItems[0].Text);
            textBox_codigoprod.Text = listView_produto.SelectedItems[0].SubItems[1].Text;
            label_nome.Text = listView_produto.SelectedItems[0].SubItems[3].Text;
            comboBox_lote.Text = listView_produto.SelectedItems[0].SubItems[4].Text;
            comboBox_fornecedor.Text = (listView_produto.SelectedItems[0].SubItems[2].Text + " - " + listView_produto.SelectedItems[0].SubItems[5].Text);
            tbPrecoCompra.Text = (listView_produto.SelectedItems[0].SubItems[7].Text);
            lb_precoproduto.Text = (listView_produto.SelectedItems[0].SubItems[8].Text);   
        }
        private void tbPrecoCompra_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref tbPrecoCompra);
        }

        private void tbPrecoCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void textBox_qtdprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }
    }
}