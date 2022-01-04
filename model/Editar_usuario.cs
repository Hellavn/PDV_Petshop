using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Petshop
{
    class Editar_usuario
    {
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String exibir_mensagem;
        public Editar_usuario(int codigo, string nome, string cpf, string senha, string endereco, string telefone, string funcao, string email)
        {
            //Comando SQL --SqlCommand
            cmd.CommandText = "update usuario set  " +
                    "nome_usuario = @nome, " +
                    "cpf_usuario = @cpf, " +
                    "senha_usuario = @senha, " +
                    "endereco_usuario = @endereco, " +
                    "telefone_usuario = @telefone, " +
                    "funcao_usuario = @funcao, " +
                    "email_usuario = @email " +
                            "where id_usuario = @codigo";
            // "values (@nome, @cpf, @senha, @endereco, @telefone, @funcao, @email)"
            //parametros
            cmd.Parameters.AddWithValue("@codigo", codigo);            
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@funcao", funcao);
            cmd.Parameters.AddWithValue("@email", email);

            try
            {
                //conexao com o banco
                cmd.Connection = con.Conectar();

                // executar comando de editar cliente de cliente
                cmd.ExecuteNonQuery();

                //desconectar do banco
                con.Desconectar();
                //mostrar mensagem de sucesso na operação
                this.exibir_mensagem = "Editado com sucesso!";
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
