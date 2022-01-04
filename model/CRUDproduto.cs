using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Petshop.view
{
    public class CRUDproduto
    {

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String exibir_mensagem = "";

        //construtuor 
        public int codigo;
        public string nome;
        public float preco;
        public string marca;
        public string categoria;
        public string estado;
        public float precocompra;
        public double margemdelucro = 0;
        public string id_marca;
        public string id_categoria;

        public CRUDproduto(int codigo, string nome, float preco, string marca, string categoria, string idmarca, string idcategoria, string estado, float precocompra, double margemdelucro)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.preco = preco;
            this.marca = marca;
            this.categoria = categoria;
            this.precocompra = precocompra;
            this.margemdelucro = margemdelucro;
            this.id_marca = idmarca;
            this.id_categoria = idcategoria;


            cmd.Parameters.AddWithValue("@codigo", this.codigo);
            cmd.Parameters.AddWithValue("@nome", this.nome);
            cmd.Parameters.AddWithValue("@preco", this.preco);
            cmd.Parameters.AddWithValue("@marca", this.marca);
            cmd.Parameters.AddWithValue("@categoria", this.categoria);
            if (estado.Equals("Ativado"))
            {
                this.estado = "1";
            }
            else
            {
                this.estado = "0";
            }
            cmd.Parameters.AddWithValue("@estado", this.estado);
            cmd.Parameters.AddWithValue("@precocompra", this.precocompra);
            cmd.Parameters.AddWithValue("@margemdelucro", this.margemdelucro);
            cmd.Parameters.AddWithValue("@idmarca", this.id_marca);
            cmd.Parameters.AddWithValue("@idcategoria", this.id_categoria);


        }

        public void cadastrar_produto()
        {
            //comando sql -- sqlCommand
            cmd.CommandText = "insert into produto " +
                "(nome_produto, preco_produto, marca, categoria, id_marca, id_categoria, estado_produto, preco_compra, margem_lucro)" +
                "values (@nome, @preco, @marca, @categoria, @idmarca, @idcategoria, @estado, @precocompra, @margemdelucro)";
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
                this.exibir_mensagem = "Erro ao conectar ao bando de dados \n" + erro;
            }
        }

        public void editar_produto()
        {
            //comando sql -- sqlCommand
            cmd.CommandText = "update produto set  " +
                    "nome_produto = @nome, " +
                    "preco_produto = @preco, " +
                    "marca = @marca, " +
                    "categoria = @categoria, " +
                    "id_marca = @idmarca, "+
                    " id_categoria = @idcategoria, " +
                    "estado_produto = @estado, " +
                    "margem_lucro = @margemdelucro, " +
                    "preco_compra = @precocompra " +
                              "where id_produto = @codigo";
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

        public void excluir_produto()
        {
            //comando sql -- sqlCommand
            cmd.CommandText = "update produto set estado_produto = 0 where id_produto = @codigo ";

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
