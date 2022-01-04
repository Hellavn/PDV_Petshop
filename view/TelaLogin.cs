using Projeto_Petshop.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Petshop
{
    public partial class telaLogin : Form
    {
        public string funcao = "";
        public int id_usuario = 0;
        public telaLogin()
        {
            InitializeComponent();
        }

        private void button_logar_Click(object sender, EventArgs e)
        {
            if (!(textBox_usuario.Text.Equals("") || textBox_senha.Text.Equals("")))
            {
                Login logar = new Login(textBox_usuario.Text, GerarHashMd5(textBox_senha.Text));
                logar.realizar_login();
                this.funcao = logar.funcao;
                this.id_usuario = logar.id_usuario;
                if (logar.achou == true)
                {
                    TelaPrincipal menu = new TelaPrincipal(funcao, id_usuario);
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorreto!");
                }
            }
            else
            {
                if (textBox_usuario.Text.Equals(""))
                {
                    MessageBox.Show("Favor informar o usuário");
                }
                else
                {
                    MessageBox.Show("Favor informar a senha.");
                }
            }  
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
