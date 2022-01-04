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
    public partial class GerirCliente : Form
    {
        public int codigo = -1;
        public bool validar = false;
        public bool validartel = false;
        public bool validaremail = false;
       
        public GerirCliente()
        {
            InitializeComponent();
        }
        private void GerirCliente_Load(object sender, EventArgs e)
        {
            CarregarListView();
        }

        public static bool ValidarTel(string tel){

            if (tel.Length != 11)
                return false;
            else
                return true;
        }

        public static bool ValidarEmail(string email)
        {
            if (email.Contains("@"))
                return true;
            else
                return false;
        }

        public static bool ValidarCPF(string cpf)
        {
            if (cpf.Length != 11 || cpf.Equals("11111111111"))
                return false;
            else
            {
                int soma = 0;
                for (int i = 0; i < 9; i++)
                {
                    soma += (Convert.ToInt32(cpf[i]) - 48) * (10 - i);
                }
                int digito = (11 - (soma % 11)) > 9 ? 0 : 11 - (soma % 11);

                if (digito == Convert.ToInt32(cpf[9] - 48))
                {
                    soma = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        soma += (Convert.ToInt32(cpf[i]) - 48) * (11 - i);
                    }
                    digito = (11 - (soma % 11)) > 9 ? 0 : 11 - (soma % 11);

                    if (digito == Convert.ToInt32(cpf[10] - 48))
                        return true;
                }
            }
            return false;
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
            listView_cliente.LabelEdit = true;
            listView_cliente.AllowColumnReorder = true;
            listView_cliente.FullRowSelect = true;
            try
            {
                Conexao con = new Conexao();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from cliente where estado_cliente = 1";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con.Conectar();

                SqlDataReader cliente = cmd.ExecuteReader();
                listView_cliente.Items.Clear();
                while (cliente.Read())
                {
                    var lv = new ListViewItem(cliente.GetInt32(0).ToString());
                    lv.SubItems.Add(cliente.GetString(1));
                    lv.SubItems.Add(cliente.GetString(2));
                    lv.SubItems.Add(cliente.GetString(3));
                    lv.SubItems.Add(cliente.GetString(4));
                    lv.SubItems.Add(cliente.GetString(5));
                    listView_cliente.Items.Add(lv);
                }
                con.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
        }

        private void listView_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigo = int.Parse(listView_cliente.SelectedItems[0].SubItems[0].Text);
            textBox_nomecliente.Text = listView_cliente.SelectedItems[0].SubItems[1].Text;
            textBox_cpfcliente.Text = listView_cliente.SelectedItems[0].SubItems[2].Text;
            textBox_emailcliente.Text = listView_cliente.SelectedItems[0].SubItems[3].Text;
            textBox_endcliente.Text = listView_cliente.SelectedItems[0].SubItems[4].Text;
            textBox_telcliente.Text = listView_cliente.SelectedItems[0].SubItems[5].Text;
            textBox_cpfcliente.Enabled = false;
            CarregarListView();
        }

        public bool verificarcpf()
        {
            bool existelinha = true;
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@cpf", textBox_cpfcliente.Text);
                cmd.CommandText = "select * from cliente where cpf_cliente = @cpf";
                
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
                //MessageBox.Show("Não foi possível validar CPF!");
            }
            return existelinha;
        }

        private void button_cadastrarcliente_Click(object sender, EventArgs e)
        {
            if (!(textBox_nomecliente.Text == string.Empty || textBox_cpfcliente.Text == string.Empty || textBox_emailcliente.Text == string.Empty || textBox_endcliente.Text == string.Empty || textBox_telcliente.Text == string.Empty))
            {
                
                if (codigo == -1)
                {

                    if (verificarcpf())
                    {
                        DialogResult dialogResult = MessageBox.Show("Deseja Cadastrar novo usuário?", "ALERTA", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            validaremail = ValidarEmail(textBox_emailcliente.Text);

                            textBox_telcliente.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                            validartel = ValidarTel(textBox_telcliente.Text);
                            textBox_telcliente.TextMaskFormat = MaskFormat.IncludeLiterals;

                            textBox_cpfcliente.TextMaskFormat = MaskFormat.IncludePrompt;
                            validar = ValidarCPF(textBox_cpfcliente.Text);
                            textBox_cpfcliente.TextMaskFormat = MaskFormat.IncludeLiterals;
                            if (validar == true && validartel == true && validaremail == true)
                            {
                                CRUDcliente cad = new CRUDcliente(codigo, textBox_nomecliente.Text, textBox_cpfcliente.Text, textBox_emailcliente.Text, textBox_endcliente.Text, textBox_telcliente.Text);
                                cad.cadastrar_cliente();
                                MessageBox.Show(cad.exibir_mensagem);
                                CarregarListView();
                                Limpar();
                            }
                            else
                            {
                                if (validar == false)
                                    MessageBox.Show("Favor informar CPF valido");
                                if (validartel == false)
                                    MessageBox.Show("Favor informar número valido");
                                if (validaremail == false)
                                    MessageBox.Show("Favor informar email valido");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Operação cancelada.");
                           
                        }
                    }
                    else
                    {
                        MessageBox.Show("CPF já existente.");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario já existente");
                    Limpar();
                    codigo = -1;
                    textBox_cpfcliente.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Favor preencher todos os campos.");
            }
        }

        private void button_editarcliente_Click(object sender, EventArgs e)
        {
            
            if (!(textBox_nomecliente.Text == string.Empty || textBox_cpfcliente.Text == string.Empty || textBox_emailcliente.Text == string.Empty || textBox_endcliente.Text == string.Empty || textBox_telcliente.Text == string.Empty))
            {
                if (codigo != -1)
                {
                        
                        DialogResult dialogResult = MessageBox.Show("Deseja editar usuário?", "ALERTA", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            validaremail = ValidarEmail(textBox_emailcliente.Text);

                            textBox_telcliente.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                            validartel = ValidarTel(textBox_telcliente.Text);
                            textBox_telcliente.TextMaskFormat = MaskFormat.IncludeLiterals;

                            textBox_cpfcliente.TextMaskFormat = MaskFormat.IncludePrompt;
                            validar = ValidarCPF(textBox_cpfcliente.Text);
                            textBox_cpfcliente.TextMaskFormat = MaskFormat.IncludeLiterals;
                            if (validar == true && validartel == true && validaremail == true)
                            {
                                CRUDcliente cad = new CRUDcliente(codigo, textBox_nomecliente.Text, textBox_cpfcliente.Text, textBox_emailcliente.Text, textBox_endcliente.Text, textBox_telcliente.Text);
                                cad.editar_cliente();
                                MessageBox.Show(cad.exibir_mensagem);
                                CarregarListView();
                                Limpar();
                                textBox_cpfcliente.Enabled = true;
                               
                            }
                            else
                            {
                                if (validar == false)
                                    MessageBox.Show("Favor informar CPF valido");
                                if (validartel == false)
                                    MessageBox.Show("Favor informar número valido");
                                if (validaremail == false)
                                    MessageBox.Show("Favor informar email valido");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Operação cancelada.");
                            textBox_cpfcliente.Enabled = true;
                        }
                    
                }
                else
                {
                    MessageBox.Show("O usuário que está tentando editar não existe");
                    CarregarListView();
                    Limpar();
                    textBox_cpfcliente.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("favor preencher todos os campos");
            }

        }

        private void button_excluircliente_Click(object sender, EventArgs e)
        {
            if (codigo != -1)
            {

                DialogResult dialogResult = MessageBox.Show("Deseja excluir usuário? \n Essa ação não pode ser revertida.", "ALERTA", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CRUDcliente cad = new CRUDcliente(codigo, textBox_nomecliente.Text, textBox_cpfcliente.Text, textBox_emailcliente.Text, textBox_endcliente.Text, textBox_telcliente.Text);
                    cad.excluir_cliente();
                    MessageBox.Show(cad.exibir_mensagem);
                    CarregarListView();
                    Limpar();
                }
            }
            else
            {
                MessageBox.Show("O usuário que está tentando excluir não existe");
                CarregarListView();
            }
        }
    }
}
