using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Petshop
{
    public class CRUDMarca
    {
        Conexao conexao = new Conexao();
        public SqlCommand cmd = new SqlCommand();
        public String exibir_mensagem = "";

        public string nome;
        public bool  estado;
        public int id;

        public CRUDMarca(int id, string nome, bool estado)
        {
            this.nome = nome;
            this.estado = estado;
            this.id = id;

            cmd.Parameters.AddWithValue("@estado", this.estado);
            cmd.Parameters.AddWithValue("@nome", this.nome);
            cmd.Parameters.AddWithValue("@id", this.id);
        }

        public void cadastrar_marca()
        {

            //nome, cpf, email, endereco, telefone
            //comando sql -- sqlCommand
            cmd.CommandText = "insert into marca " +
                "(nome_marca, estado_marca)" +
                "values (@nome, @estado)";
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

        public void editar_marca()
        {
            //comando sql -- sqlCommand
            cmd.CommandText = "update marca set  " +
                    "nome_marca = @nome, " +
                    "estado_marca = @estado " +
                              "where id_marca = @id";

            try
            {
                //conexao com o banco
                cmd.Connection = conexao.Conectar();

                // executar comando de cadastro de cliente
                cmd.ExecuteNonQuery();

                //desconectar do banco
                conexao.Desconectar();

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

        public void excluir_marca()
        {
            //comando sql -- sqlCommand
            if (estado)
            {
                cmd.CommandText = "update marca set estado_marca = 0 where id_marca = @id;";
            }
            else
            {
                cmd.CommandText = "update marca set estado_marca = 1 where id_marca = @id;";
            }
            

            try
            {
                //conexao com o banco
                cmd.Connection = conexao.Conectar();

                // executar comando de cadastro de cliente
                cmd.ExecuteNonQuery();

                //desconectar do banco
                conexao.Desconectar();
                //mostrar mensagem de sucesso na operação
                this.exibir_mensagem = "Desativado com sucesso!";
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
