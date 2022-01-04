using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Petshop
{
    class CRUDcliente
    {
        Conexao conexao = new Conexao();
        public SqlCommand cmd = new SqlCommand();
        public String exibir_mensagem = "";

        public int codigo;
        public string nome;
        public string cpf;
        public string email;
        public string endereco;
        public string telefone;

        public CRUDcliente(int codigo, string nome, string cpf, string email, string endereco, string telefone)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
            this.endereco = endereco;
            this.telefone = telefone;

            //nome, cpf, email, endereco, telefone
            cmd.Parameters.AddWithValue("@codigo", this.codigo);
            cmd.Parameters.AddWithValue("@nome", this.nome);
            cmd.Parameters.AddWithValue("@cpf", this.cpf);
            cmd.Parameters.AddWithValue("@email", this.email);
            cmd.Parameters.AddWithValue("@endereco", this.endereco);
            cmd.Parameters.AddWithValue("@telefone", this.telefone);
        }

        public void cadastrar_cliente()
        {

            //nome, cpf, email, endereco, telefone
            //comando sql -- sqlCommand
            cmd.CommandText = "insert into cliente " +
                "(nome_cliente, cpf_cliente, email_cliente, endereco_cliente, numero_cliente, estado_cliente)" +
                "values (@nome, @cpf, @email, @endereco, @telefone, 1)";
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

        public void editar_cliente()
        {
            //comando sql -- sqlCommand
            cmd.CommandText = "update cliente set  " +
                    "nome_cliente = @nome, " +
                    "cpf_cliente = @cpf, " +
                    "email_cliente = @email, " +
                    "endereco_cliente = @endereco, " +
                    "numero_cliente = @telefone, " +
                    "estado_cliente = 1 " +
                              "where id_cliente = @codigo";

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

        public void excluir_cliente()
        {
            //comando sql -- sqlCommand
            cmd.CommandText = "update cliente set estado_cliente = 0 where id_cliente = @codigo;";

            try
            {
                //conexao com o banco
                cmd.Connection = conexao.Conectar();

                // executar comando de cadastro de cliente
                cmd.ExecuteNonQuery();

                //desconectar do banco
                conexao.Desconectar();
                //mostrar mensagem de sucesso na operação
                this.exibir_mensagem = "Excluido com sucesso!";
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
