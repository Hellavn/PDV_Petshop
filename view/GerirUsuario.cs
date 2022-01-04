using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Petshop.view
{
    public partial class GerirUsuario : Form
    {
        public bool validartel = false;
        public bool validaremail = false;
        public bool validar = false;
        public int codigo = -1;
        public string mensagem;
        public GerirUsuario()
        {
            InitializeComponent();
        }
        public static bool ValidarTel(string tel)
        {

            if (tel.Length == 11) 
                return true;
            else
                return false;
        }
        public static bool ValidarEmail(string email)
        {
            if (email.Contains("@"))
                return true;
            else
                return false;
        }

        private void GerirUsuario_Load(object sender, EventArgs e)
        {
            CarregarListView();
            comboBox_funcao.Text = "Vendedor";
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

        //Método Limpar         
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
                comboBox_funcao.Text = "Vendedor";
            }
        }

        public void CarregarListView()
        {
            listView_usuario.LabelEdit = true;
            listView_usuario.AllowColumnReorder = true;
            listView_usuario.FullRowSelect = true;
            try
            {
                Conexao con = new Conexao();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from usuario";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con.Conectar();

                SqlDataReader usuario = cmd.ExecuteReader();
                listView_usuario.Items.Clear();
                while (usuario.Read())
                {
                    var lv = new ListViewItem(usuario.GetInt32(0).ToString());
                    lv.SubItems.Add(usuario.GetString(1));
                    lv.SubItems.Add(usuario.GetString(2));
                    lv.SubItems.Add(usuario.GetString(3));
                    lv.SubItems.Add(usuario.GetString(4));
                    lv.SubItems.Add(usuario.GetString(5));
                    lv.SubItems.Add(usuario.GetString(6));
                    lv.SubItems.Add(usuario.GetString(7));
                    listView_usuario.Items.Add(lv);
                }


                con.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
        }

        private void button_cadastrarUsuario_Click(object sender, EventArgs e)
        {
            if(textBox_senhaUsuario.Text == tb_repSenha.Text)
            {
                if (codigo == -1)
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja cadastrar novo usuário? ", "ALERTA", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        validaremail = ValidarEmail(textBox_emailUsuario.Text);

                        textBox_telUsuario.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                        validartel = ValidarTel(textBox_telUsuario.Text);
                        textBox_telUsuario.TextMaskFormat = MaskFormat.IncludeLiterals;

                        textBox_cpfUsuario.TextMaskFormat = MaskFormat.IncludePrompt;
                        validar = ValidarCPF(textBox_cpfUsuario.Text);
                        textBox_cpfUsuario.TextMaskFormat = MaskFormat.IncludeLiterals;
                        if (validar == true && validaremail == true && validartel == true)
                        {
                            // instanciar cadastro
                            //ordem a ser passado informação: nome, cpf, senha, endereco, telefone, funcao, email
                            Cadastrar_usuario cad = new Cadastrar_usuario(textBox_Nomeusuario.Text, textBox_cpfUsuario.Text,
                                GerarHashMd5(textBox_senhaUsuario.Text), textBox_enderecoUsuario.Text, textBox_telUsuario.Text,
                                comboBox_funcao.Text, textBox_emailUsuario.Text);
                            CarregarListView();
                            // exibir mensagem de retorno do cadastro (se cadastrou ou não)
                            MessageBox.Show(cad.exibir_mensagem);
                            Limpar();
                        }
                        else
                        {
                            if (validar == false)
                                MessageBox.Show("Favor informar CPF Valido");
                            if (validartel == false)
                                MessageBox.Show("Favor informar telefone Valido");
                            if (validaremail == false)
                                MessageBox.Show("Favor informar e-mail Valido");
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Usuário já existente, não é possível cadastrar novamente. " +
                                                                "\n Desejesa Cadastratrar novo usuário?", "ALERTA", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Limpar();
                        codigo = -1;
                    }
                }
            }
            else 
            {
                MessageBox.Show("Senhas não coincidem.");
            }
        }

        private void button_excluirUsuario_Click(object sender, EventArgs e)
        {
            if (!(codigo == -1))
            {
                DialogResult dialogResult = MessageBox.Show("Deseja excluir usuário? \n Essa ação não pode ser revertida.", "ALERTA", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Excluir_Usuario cad = new Excluir_Usuario(codigo);
                    MessageBox.Show(cad.exibir_mensagem);
                    CarregarListView();
                    Limpar();
                }
            }
            else
            {
                MessageBox.Show("Usuario que está tentando excluir não existe.");
            }
        }

        // quando clicar em um item da listview, os dados selecionados são colocados nos campos
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigo = int.Parse(listView_usuario.SelectedItems[0].SubItems[0].Text);
            textBox_Nomeusuario.Text = listView_usuario.SelectedItems[0].SubItems[1].Text;
            textBox_cpfUsuario.Text = listView_usuario.SelectedItems[0].SubItems[2].Text;
            textBox_senhaUsuario.Text = listView_usuario.SelectedItems[0].SubItems[3].Text;
            textBox_enderecoUsuario.Text = listView_usuario.SelectedItems[0].SubItems[4].Text;
            textBox_telUsuario.Text = listView_usuario.SelectedItems[0].SubItems[5].Text;
            comboBox_funcao.Text = listView_usuario.SelectedItems[0].SubItems[6].Text;
            textBox_emailUsuario.Text = listView_usuario.SelectedItems[0].SubItems[7].Text;
            CarregarListView();
        }

        private void button_editarUsuario_Click(object sender, EventArgs e)
        {
            if (!(codigo == -1))
            {
                if (textBox_senhaUsuario.Text == tb_repSenha.Text)
                {

                    DialogResult dialogResult = MessageBox.Show("Deseja editar usuário? \n Essa ação não pode ser revertida. ", "ALERTA", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        validaremail = ValidarEmail(textBox_emailUsuario.Text);

                        textBox_telUsuario.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                        validartel = ValidarTel(textBox_telUsuario.Text);
                        textBox_telUsuario.TextMaskFormat = MaskFormat.IncludeLiterals;

                        textBox_cpfUsuario.TextMaskFormat = MaskFormat.IncludePrompt;
                        validar = ValidarCPF(textBox_cpfUsuario.Text);
                        textBox_cpfUsuario.TextMaskFormat = MaskFormat.IncludeLiterals;
                        if (validar == true && validaremail == true && validartel == true)
                        {
                            //ordem a ser passado informação: nome, cpf, senha, endereco, telefone, funcao, email
                            Editar_usuario cad = new Editar_usuario(codigo, textBox_Nomeusuario.Text, textBox_cpfUsuario.Text,
                                textBox_senhaUsuario.Text, textBox_enderecoUsuario.Text, textBox_telUsuario.Text,
                                comboBox_funcao.Text, textBox_emailUsuario.Text);

                            // exibir mensagem de retorno da edição
                            MessageBox.Show(cad.exibir_mensagem);

                            CarregarListView();
                            Limpar();
                        }
                        else
                        {
                            if (validar == false)
                                MessageBox.Show("Favor informar CPF valido");
                            if (validaremail == false)
                                MessageBox.Show("Favor informar email valido");
                            if (validartel == false)
                                MessageBox.Show("Favor informar telefone valido");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário que está tentando editar não existe!");
                    }
                }
                else
                {
                    MessageBox.Show("Senhas não coincidem.");
                }
            }
        }

        private void button_cadusuarioMenu_Click(object sender, EventArgs e)
        {
            TelaPrincipal menu = new TelaPrincipal();
            menu.ShowDialog();
            this.Close();
        }

        public static string GerarHashMd5(string senha)
        {
            MD5 md5Hash = MD5.Create();
            // Converter a String para array de bytes, que é como a biblioteca trabalha.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));

            // Cria-se um StringBuilder para recompôr a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop para formatar cada byte como uma String em hexadecimal
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}
