using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Petshop
{
    public class Excluir_Usuario
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String exibir_mensagem = "";
        //construtor
        public Excluir_Usuario(int codigo)
        {
            //comando sql -- sqlCommand
            cmd.CommandText = "update usuario set estado_usuario = 0 where id_usuario = @codigo";
            //parametros
            cmd.Parameters.AddWithValue("@id_usuario", codigo);
            
               try
            {
                //conexao com o banco
                cmd.Connection = conexao.Conectar();

                // executar comando de cadastro de cliente
                cmd.ExecuteNonQuery();

                //desconectar do banco
                conexao.Desconectar();
                //mostrar mensagem de sucesso na operação
                this.exibir_mensagem = "Deletado com sucesso!";
            }
            catch (SqlException erro)
            {
                //se entra no catch caso qualquer linha do try dê errado, a variavel erro recolhe as informações do que aconteceu
                // exibir erro/sucesso
                this.exibir_mensagem = "Erro ao conectar ao bando de dados";
            }
            //desconectar
        }
    }
}
