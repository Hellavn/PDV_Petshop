using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Petshop
{
    public class FinalizarCompra
    {
        // informações de conexao
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String exibir_mensagem = "";
        public int id_venda = 0;
        public int quantidade = 0;
        public int id = 0;
        public int quantidade_venda = 0;
        public int balanco = 0;
        public void efetuar_venda(string valortotal, string formapgmt, int id_usuario)
        {
            //MessageBox.Show(valortotal + "\n" + formapgmt + "\n" + id_usuario);
            cmd.Parameters.AddWithValue("@valortotal", double.Parse(valortotal));
            cmd.Parameters.AddWithValue("@formapagamento", formapgmt);
            cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
            cmd.Parameters.AddWithValue("@data", DateTime.Today);

            //comando sql -- sqlCommand
            cmd.CommandText = "insert into venda " +
                "(total_venda, forma_pagamento, data, id_cliente, id_usuario) " +
                "values (@valortotal, @formapagamento, @data, '1', @id_usuario)";
            try
            {
                //conexao com o banco
                cmd.Connection = conexao.Conectar();

                // executar comando de cadastro de cliente
                cmd.ExecuteNonQuery();

                //desconectar do banco
                conexao.Desconectar();
                //mostrar mensagem de sucesso na operação
                this.exibir_mensagem = "Venda realizada com sucesso!";
            }
            catch (SqlException erro)
            {
                //se entra no catch caso qualquer linha do try dê errado, a variavel erro recolhe as informações do que aconteceu
                // exibir erro/sucesso
                this.exibir_mensagem = "Erro ao efetuar venda.";

            }
        }

        public void itens(int id_produto, int quantidade_itens, double valor_total_itens, string lote, string nome_produto, int id_fornecedor, string nome_fornecedor)
        {
            //id_venda = pegarIDvenda();
            id_venda = pegarIDvenda();
            int venda = id_venda;
           //id_venda, id_produto, quantidade_itens
            //valor_total_itens, lote, nome_produto, id_fornecedor, nome_fornecedor
            cmd.Parameters.AddWithValue("@id_venda", venda);
            cmd.Parameters.AddWithValue("@id_produto", id_produto);
            cmd.Parameters.AddWithValue("@quantidade_itens", quantidade_itens);
            cmd.Parameters.AddWithValue("@valor_total_itens", valor_total_itens);
            cmd.Parameters.AddWithValue("@lote", lote);
            cmd.Parameters.AddWithValue("@nome", nome_produto);
            cmd.Parameters.AddWithValue("@id_fornecedor", id_fornecedor);
            cmd.Parameters.AddWithValue("@nome_produto", nome_produto);
            cmd.Parameters.AddWithValue("@datavenda", DateTime.Today);

            //comando sql -- sqlCommand
            cmd.CommandText = "insert into itens(id_venda, id_produto, quantidade_itens, valor_total_itens, lote, nome_produto, id_fornecedor, nome_fornecedor, data_venda)" +
            "values(@id_venda, @id_produto, @quantidade_itens, @valor_total_itens, @lote, @nome, @id_fornecedor, @nome_produto, @datavenda);";
            try
            {
                //conexao com o banco
                cmd.Connection = conexao.Conectar();

                // executar comando de cadastro de cliente
                cmd.ExecuteNonQuery();

                //desconectar do banco
                conexao.Desconectar();
                //mostrar mensagem de sucesso na operação
                this.exibir_mensagem = "Produto cadastrado!";
            }
            catch (SqlException erro)
            {
                //se entra no catch caso qualquer linha do try dê errado, a variavel erro recolhe as informações do que aconteceu
                // exibir erro/sucesso
                this.exibir_mensagem = "Erro ao inserir produto";
                //MessageBox.Show("Erro ao cadastrar itens \n" + erro);            
            }
        }

        public void darBaixa(int id_produto, string lote, int id_fornecedor, int quantidade)
        {
            //id_produto, lote, id_fornecedor, quantidade

            this.quantidade_venda = quantidade;
            cmd.Parameters.AddWithValue("@id_produto", id_produto);
            cmd.Parameters.AddWithValue("@lote", lote);
            cmd.Parameters.AddWithValue("@id_fornecedor", id_fornecedor);
            cmd.CommandText = "select id_fornecedor_produto, quantidade_produto from fornecedor_produto" +
                " where id_produto = @id_produto and lote = @lote and id_fornecedor = @id_fornecedor";
            try
            {
                //conexao com o banco
                cmd.Connection = conexao.Conectar();

                SqlDataReader produto = cmd.ExecuteReader();
                while (produto.Read())
                {
                    id = produto.GetInt32(0);
                    quantidade = produto.GetInt32(1);
                }

                //desconectar do banco
                conexao.Desconectar();
                //mostrar mensagem de sucesso na operação
                this.exibir_mensagem = "Consulta realizada com sucesso!";
                //MessageBox.Show(exibir_mensagem);
            }
            catch (SqlException erro)
            {
                //se entra no catch caso qualquer linha do try dê errado, a variavel erro recolhe as informações do que aconteceu
                // exibir erro/sucesso
                this.exibir_mensagem = "Erro ao realizar consulta";
            }

            // ----------------------------------------------------------------------------------------------------------
            balanco = quantidade - quantidade_venda;
            if (balanco > 0)
            {
                try
                {
                    cmd.Connection = conexao.Conectar();
                    cmd.Parameters.AddWithValue("@id_fornecedor_produto", id);
                    cmd.Parameters.AddWithValue("@balanco", balanco);


                    cmd.CommandText = "update fornecedor_produto set quantidade_produto = @balanco" +
                        " where id_fornecedor_produto = @id_fornecedor_produto";
                    cmd.ExecuteNonQuery();
                    conexao.Desconectar();
                }
                catch (SqlException erro)
                {
                    this.exibir_mensagem = "Erro ao conectar com o banco de dados. Nãp foi possível efetuar o balanço de caixa.";
                    MessageBox.Show(exibir_mensagem, erro.Message);
                }
                
            }
            else
            {
                try
                {
                    cmd.Connection = conexao.Conectar();
                    cmd.Parameters.AddWithValue("@id_fornecedor_produto", id);
                   
                    cmd.CommandText = "delete from fornecedor_produto " +
                        "where id_fornecedor_produto = @id_fornecedor_produto";
                    cmd.ExecuteNonQuery ();
                    conexao.Desconectar();
                }
                catch (SqlException erro)
                {
                    this.exibir_mensagem = "Erro ao conectar com o banco de dados. Não foi possível remover produto sem estoque do caixa.";
                    MessageBox.Show(exibir_mensagem, erro.Message);
                }
            }
        }

        public int pegarIDvenda()
        {
            try
            {
                cmd.CommandText = "select MAX(id_venda) from venda";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexao.Conectar();
                if (cmd.ExecuteScalar() == DBNull.Value)
                {
                    id_venda = 1;
                }
                else
                {
                    id_venda = Convert.ToInt32(cmd.ExecuteScalar());
                }

                conexao.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro recuperar ID venda!");
            }
            return id_venda;
        }

    }
}
