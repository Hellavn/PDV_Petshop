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
    public class ControleEstoque
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String exibir_mensagem = "";
        //int quantidade = 0;
        //int apoio = 0;


        public int cod; //id_produto
        public int idfornecedor; //id_fornecedor
        public string lote;
        public int quantidade_produto;
        public DateTime fabricacao; // fabricacao_produto
        public DateTime validade; // datavalidade
        public string nome; // nome_produto
        public string nomefornecedor;
        public double valor;
        public double precocompra;
        public double margem;

        //public int qtdAtual;
        //ControleEstoque add = new ControleEstoque(int.Parse(textBox_codigoprod.Text),
        //int.Parse(fornecedor[0]), fornecedor[1], label_nome.Text, comboBox_lote.Text, int.Parse(textBox_qtdprod.Text), fabricacao, validade, valor[1], precocompra[1]);
        public ControleEstoque(int codigo, int idfornecedor, string nomefor, string nome, string lote, int qtd, DateTime fabricacao, DateTime validade, string valor, string precocompra)
        {
            this.cod = codigo;
            this.idfornecedor = idfornecedor;
            this.nome = nome;
            this.lote = lote;
            this.quantidade_produto = qtd;
            this.fabricacao = fabricacao;
            this.validade = validade;
            this.nomefornecedor = nomefor;
            this.valor = double.Parse(valor);
            this.precocompra = double.Parse(precocompra);
            margem = ((this.valor - this.precocompra) / this.precocompra)*100;

            cmd.Parameters.AddWithValue("@id_produto", this.cod);
            cmd.Parameters.AddWithValue("@id_fornecedor", this.idfornecedor);
            cmd.Parameters.AddWithValue("@lote", this.lote);
            cmd.Parameters.AddWithValue("@quantidade_produto", this.quantidade_produto);
            cmd.Parameters.AddWithValue("@fabricacao", this.fabricacao);
            cmd.Parameters.AddWithValue("@validade", this.validade);
            cmd.Parameters.AddWithValue("@nome", this.nome);
            cmd.Parameters.AddWithValue("@nomefornecedor", this.nomefornecedor);
            cmd.Parameters.AddWithValue("@valor", this.valor);
            cmd.Parameters.AddWithValue("@precocompra", this.precocompra);
            cmd.Parameters.AddWithValue("@margem", this.margem);

        }

        public void Movimentar()
        {
            //comando sql -- sqlCommand

            
            cmd.CommandText = "UPDATE fornecedor_produto set " +
                 "quantidade_produto = @quantidade_produto, valor_produto = @valor, valor_compra = @precocompra, margem_lucro = @margem " +
                 "where id_produto = @id_produto and id_fornecedor = @id_fornecedor and lote = @lote";
            try
            {
                //conexao com o banco
                cmd.Connection = conexao.Conectar();

                // executar comando de cadastro de cliente
                cmd.ExecuteNonQuery();

                //desconectar do banco
                conexao.Desconectar();
                //mostrar mensagem de sucesso na operação
                this.exibir_mensagem = "Operação realizada com sucesso!";
            }
            catch
            {
                //se entra no catch caso qualquer linha do try dê errado, a variavel erro recolhe as informações do que aconteceu
                
                this.exibir_mensagem = "Fazer tentativa de cadastrar novo. (Erro movimentar.)";
            }
        }

        public void inserirNovo()
        {
            //comando sql -- sqlCommand


            cmd.CommandText = "insert into fornecedor_produto " +
            "(id_produto, id_fornecedor, lote, quantidade_produto, fabricacao_produto, datavalidade, nome_produto, nome_fornecedor, valor_produto, valor_compra, margem_lucro) " +
            "values (@id_produto, @id_fornecedor, @lote, @quantidade_produto, @fabricacao, @validade, @nome, @nomefornecedor, @valor, @precocompra, @margem) ";
             
            try
            {
                //conexao com o banco
                cmd.Connection = conexao.Conectar();

                // executar comando de cadastro de cliente
                cmd.ExecuteNonQuery();

                //desconectar do banco
                conexao.Desconectar();
                //mostrar mensagem de sucesso na operação
                this.exibir_mensagem = "Operação realizada com sucesso!";
            }
            catch
            {
                //se entra no catch caso qualquer linha do try dê errado, a variavel erro recolhe as informações do que aconteceu
                // exibir erro/sucesso

                this.exibir_mensagem = "Fazer tentativa de cadastrar novo. (erro inserir novo)";
            }
        }
    }
}
