using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Petshop
{
    public class Cadastrar_usuario
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String exibir_mensagem = "";
        //construtor
        public Cadastrar_usuario(string nome, string cpf, string senha, string endereco, string telefone, string funcao, string email)
        {
            //comando sql -- sqlCommand
            cmd.CommandText = "insert into usuario " +
                "(nome_usuario, cpf_usuario, senha_usuario, endereco_usuario, telefone_usuario, funcao_usuario, email_usuario)" +
                "values (@nome, @cpf, @senha, @endereco, @telefone, @funcao, @email)";
            //parametros
            cmd.Parameters.AddWithValue("@nome",nome);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@funcao", funcao);
            cmd.Parameters.AddWithValue("@email", email);

            try
            {
                //conexao com o banco
                cmd.Connection = conexao.Conectar();

                // executar comando de cadastro de cliente
                cmd.ExecuteNonQuery();

                //desconectar do banco
                conexao.Desconectar();
                //mostrar mensagem de sucesso na operação
                this.exibir_mensagem = "Cadastrado com sucesso!";
            }
            catch (SqlException erro)
            {
                //se entra no catch caso qualquer linha do try dê errado, a variavel erro recolhe as informações do que aconteceu
                // exibir erro/sucesso
                this.exibir_mensagem = "Erro ao conectar ao bando de dados";
            }
        }
    }
}
