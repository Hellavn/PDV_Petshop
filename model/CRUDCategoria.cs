using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Petshop
{
    public class CRUDCategoria
    {
        Conexao conexao = new Conexao();
        public SqlCommand cmd = new SqlCommand();
        public String exibir_mensagem = "";

        public string nome;
        public bool estado;
        public int id;

        public CRUDCategoria(int id, string nome, bool estado)
        {
            this.nome = nome;
            this.estado = estado;
            this.id = id;

            cmd.Parameters.AddWithValue("@estado", this.estado);
            cmd.Parameters.AddWithValue("@nome", this.nome);
            cmd.Parameters.AddWithValue("@id", this.id);
        }

        public void cadastrar_categoria()
        {

            //nome, cpf, email, endereco, telefone
            //comando sql -- sqlCommand
            cmd.CommandText = "insert into categoria " +
                "(nome_categoria, estado_categoria)" +
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

        public void editar_categoria()
        {
            //comando sql -- sqlCommand
            cmd.CommandText = "update categoria set  " +
                    "categoria = @nome, " +
                    "estado_categoria = @estado " +
                              "where id_categoria = @id";

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

        public void excluir_categoria()
        {
            //comando sql -- sqlCommand
            if (estado)
            {
                cmd.CommandText = "update categoria set estado_categoria = 0 where id_categoria = @id;";
            }
            else
            {
                cmd.CommandText = "update categoria set estado_categoria = 1 where id_categoria = @id;";
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