using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Petshop.view
{
    class CRUDFornecedor
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String exibir_mensagem = "";

        public int codigo;
        public string nome;
        public string cidade;
        public string endereco;
        public string email;
        public string telefone;
        public string cnpj;
        public string estado;
        //construtor
        //codigo(id_fornecedor) @nome, @cidade, @endereco, @email, @telefone, @cnpj
        public CRUDFornecedor(int codigo, string nome, string cidade, string endereco, string email, string telefone, string cnpj, string estado)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.cidade = cidade;
            this.endereco = endereco;
            this.email = email;
            this.telefone = telefone;
            this.cnpj = cnpj;
            if (estado.Equals("Ativado"))
            {
                this.estado = "1";
            }
            else
            {
                this.estado = "0";
            }

            cmd.Parameters.AddWithValue("@codigo", this.codigo);
            cmd.Parameters.AddWithValue("@nome", this.nome);
            cmd.Parameters.AddWithValue("@cidade", this.cidade);
            cmd.Parameters.AddWithValue("@endereco", this.endereco);
            cmd.Parameters.AddWithValue("@email", this.email);
            cmd.Parameters.AddWithValue("@telefone", this.telefone);
            cmd.Parameters.AddWithValue("@cnpj", this.cnpj);
            cmd.Parameters.AddWithValue("@estado", this.estado);
        }

        public void cadastrar_fornecdor()
        {
            //comando sql -- sqlCommand
            cmd.CommandText = "insert into fornecedor " +
                "(nome_fornecedor, cidade_fornecedor, endereco_fornecedor, email_fornecedor, telefone_fornecedor, cnpj_fornecedor, estado_fornecedor)" +
                "values (@nome, @cidade, @endereco, @email, @telefone, @cnpj, @estado)";
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

        public void editar_fornecedor()
        {
            //comando sql -- sqlCommand
            cmd.CommandText = "update fornecedor set  " +
                    "nome_fornecedor = @nome, " +
                    "cidade_fornecedor = @cidade, " +
                    "endereco_fornecedor = @endereco, " +
                    "email_fornecedor = @email, " +
                    "telefone_fornecedor = @telefone, " +
                    "cnpj_fornecedor = @cnpj, " +
                    "estado_fornecedor = @estado " +
                              "where id_fornecedor = @codigo";

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

        public void excluir_fornecedor()
        {
            //comando sql -- sqlCommand
            cmd.CommandText = "update fornecedor set estado_fornecedor = 0 where id_fornecedor = @codigo;";

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
