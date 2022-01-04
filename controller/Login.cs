using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Petshop
{
    class Login
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String exibir_mensagem = "";
        public bool achou = false; 

        public string nome;
        public string cpf;
        public string senha; 
        public string funcao;
        public int id_usuario;

        //construtor
        public Login(string cpf, string senha)
        {
            this.cpf = cpf;
            this.senha = senha;
            //parametros
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@senha", senha);
          }

        public bool realizar_login()
        {
            cmd.CommandText = "select * from usuario where cpf_usuario = @cpf and senha_usuario = @senha";
            try
            {
                //conexao com o banco
                cmd.Connection = conexao.Conectar();
                // executar comando de cadastro de cliente
                cmd.ExecuteNonQuery();
                //desconectar do banco
                
                //execytar comando
                SqlDataReader retorno = cmd.ExecuteReader();
                //desconectar
                if (retorno.HasRows)
                {
                    achou = true;
                    while (retorno.Read())
                    {
                        this.id_usuario = retorno.GetInt32(0);
                        this.nome = retorno.GetString(1).ToString();
                        this.funcao = retorno.GetString(6).ToString();

                    }
                }
                //mostrar mensagem de sucesso na operação
                this.exibir_mensagem = ("Bem vindo " + nome + "!");
                conexao.Desconectar();
            }
            catch (SqlException)
            {
                exibir_mensagem = "Erro com banco de dados!";
            }
            return achou;
        }
    }
}