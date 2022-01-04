using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto_Petshop.view
{
    public partial class GerirFornecedor : Form
    {
        public int codigo = -1;
        

        public GerirFornecedor()
        {
            InitializeComponent();
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
            }
        }

        public void CarregarListView()
        {
            listView_fornecedor.LabelEdit = true;
            listView_fornecedor.AllowColumnReorder = true;
            listView_fornecedor.FullRowSelect = true;
            try
            {
                Conexao con = new Conexao();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from fornecedor";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con.Conectar();

                SqlDataReader fornecedor = cmd.ExecuteReader();
                listView_fornecedor.Items.Clear();
                while (fornecedor.Read())
                {
                    var lv = new ListViewItem(fornecedor.GetInt32(0).ToString());
                    lv.SubItems.Add(fornecedor.GetString(1));
                    lv.SubItems.Add(fornecedor.GetString(2));
                    lv.SubItems.Add(fornecedor.GetString(3));
                    lv.SubItems.Add(fornecedor.GetString(4));
                    lv.SubItems.Add(fornecedor.GetString(5));
                    lv.SubItems.Add(fornecedor.GetString(6));

                    bool estado = fornecedor.GetBoolean(7);

                    if (estado == true)
                    {
                        lv.SubItems.Add("Ativado");
                    }
                    else
                    {
                        lv.SubItems.Add("Desativado");
                    }
                    listView_fornecedor.Items.Add(lv);
                }
                con.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
        }

        private void listView_fornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBox_nomefornecedor.Text, textBox_cidadefornecedor.Text,
            //textBox_endfornecedor.Text, textBox_emailfornecedor.Text, TextBox_telfornecedor.Text, TextBox_cnpjfornecedor.Text
            codigo = int.Parse(listView_fornecedor.SelectedItems[0].SubItems[0].Text);
            textBox_nomefornecedor.Text = listView_fornecedor.SelectedItems[0].SubItems[1].Text;
            textBox_cidadefornecedor.Text = listView_fornecedor.SelectedItems[0].SubItems[2].Text;
            textBox_endfornecedor.Text = listView_fornecedor.SelectedItems[0].SubItems[3].Text;
            textBox_emailfornecedor.Text = listView_fornecedor.SelectedItems[0].SubItems[4].Text;
            TextBox_telfornecedor.Text = listView_fornecedor.SelectedItems[0].SubItems[5].Text;
            TextBox_cnpjfornecedor.Text = listView_fornecedor.SelectedItems[0].SubItems[6].Text;
            cbEstadoFornecedor.Text = listView_fornecedor.SelectedItems[0].SubItems[7].Text;
            CarregarListView();
        }

        private void GerirFornecedor_Load(object sender, EventArgs e)
        {
            CarregarListView();
        }

        private void button_cadastrarfornecedor_Click(object sender, EventArgs e)
        {
            if (!(textBox_nomefornecedor.Text == string.Empty || textBox_cidadefornecedor.Text == string.Empty || textBox_endfornecedor.Text == string.Empty || textBox_emailfornecedor.Text == string.Empty || TextBox_telfornecedor.Text == string.Empty || TextBox_cnpjfornecedor.Text == string.Empty || cbEstadoFornecedor.Text == string.Empty))
            {
                if (codigo == -1)
                {
                    CRUDFornecedor cad = new CRUDFornecedor(codigo, textBox_nomefornecedor.Text, textBox_cidadefornecedor.Text, textBox_endfornecedor.Text, textBox_emailfornecedor.Text, TextBox_telfornecedor.Text, TextBox_cnpjfornecedor.Text, cbEstadoFornecedor.Text);
                    cad.cadastrar_fornecdor();
                    MessageBox.Show(cad.exibir_mensagem);
                    CarregarListView();
                    Limpar();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Você selecionou um fornecedor já existente. \n Deseja Cadastrar novo fornecedor?", "ALERTA", MessageBoxButtons.YesNo);
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

      

        private void button_editarfornecedor_Click(object sender, EventArgs e)
        {
            if (!(textBox_nomefornecedor.Text == string.Empty || textBox_cidadefornecedor.Text == string.Empty || textBox_endfornecedor.Text == string.Empty || textBox_emailfornecedor.Text == string.Empty || TextBox_telfornecedor.Text == string.Empty || TextBox_cnpjfornecedor.Text == string.Empty))
            {
                CRUDFornecedor cad = new CRUDFornecedor(codigo, textBox_nomefornecedor.Text, textBox_cidadefornecedor.Text, textBox_endfornecedor.Text, textBox_emailfornecedor.Text, TextBox_telfornecedor.Text, TextBox_cnpjfornecedor.Text, cbEstadoFornecedor.Text);

                if (!(codigo == -1))
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja editar fornecedor?", "ALERTA", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cad.editar_fornecedor();
                        MessageBox.Show(cad.exibir_mensagem);

                        CarregarListView();
                        Limpar();
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Esse fornecedor não existente. " +
                                                            "\n Desejesa Cadastratrar novo fornecedor?", "ALERTA", MessageBoxButtons.YesNo);
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

        private void button_excluirfornecedor_Click(object sender, EventArgs e)
        {
            if (!(codigo == -1))
            {
                DialogResult dialogResult = MessageBox.Show("Deseja excluir fornecedor? \n Essa ação não pode ser revertida.", "ALERTA", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                CRUDFornecedor cad = new CRUDFornecedor(codigo, textBox_nomefornecedor.Text, textBox_cidadefornecedor.Text, textBox_endfornecedor.Text, textBox_emailfornecedor.Text, TextBox_telfornecedor.Text, TextBox_cnpjfornecedor.Text, cbEstadoFornecedor.Text);

                cad.excluir_fornecedor();
                MessageBox.Show(cad.exibir_mensagem);
                CarregarListView();
                Limpar();
                }
                else
                {
                    MessageBox.Show("Operação cancelada");
                    Limpar();
                }
            }
            else
            {
                MessageBox.Show("fornecedor que está tentando excluir não existe.");
            }
        }
    }
}
