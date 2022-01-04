using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Petshop.view
{
    public partial class MargemLucro : Form
    {
        public int codigo = 0;
        public double valorcompra = 0;
        public double valorvenda = 0;
        public MargemLucro()
        {
            InitializeComponent();
        }

        public MargemLucro(backupBusca busca)
        {
            InitializeComponent();
        }

        private void bt_promo_Click(object sender, EventArgs e)
        {
            if(tb_margemdelucro.Text != string.Empty && tb_codprod.Text != String.Empty)
            {
                valorvenda = valorcompra * (1 + double.Parse(tb_margemdelucro.Text)/100);
                aplicarmargem();
                
                valorvenda = 0;
                valorcompra = 0;
                tb_codprod.Text = string.Empty;
                tb_margemdelucro.Text = string.Empty;
                codigo = 0;
            }
            else
            {
                MessageBox.Show("Favor passar código do produto e margem de lucro deseja.");
            }
        }

        private void tb_margemdelucro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        public void aplicarmargem()
        {
            try
            {
                Conexao con = new Conexao();
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@valorvenda", double.Parse(valorvenda.ToString("F2")));
                cmd.Parameters.AddWithValue("@id", tb_codprod.Text);
                cmd.Parameters.AddWithValue("@margem", tb_margemdelucro.Text);

                cmd.CommandText = "update fornecedor_produto set valor_produto = @valorvenda where id_produto = @id; "+
                                   "update produto set preco_produto = @valorvenda where id_produto = @id; " +
                                   "update fornecedor_produto set margem_lucro = @margem where id_produto = @id; "+
                                   "update produto set margem_lucro = @margem where id_produto = @id;";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();

                con.Desconectar();
                MessageBox.Show("Margem aplicada com sucesso.");
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao atualizar margem de lucro.\n" + erro);
            }
        }

        public void pegarvalorcompra()
        { 
            try
            {
                Conexao conexao = new Conexao();
                //Comando SQL --SqlCommand
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@id", tb_codprod.Text);
                cmd.CommandText = "SELECT MAX(valor_compra) as 'Valor compra' from fornecedor_produto where id_produto = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexao.Conectar();
                if (cmd.ExecuteScalar() == DBNull.Value)
                {
                    MessageBox.Show("Produto desejado não existe em estoque");
                        
                }
                else
                {
                    valorcompra = Convert.ToDouble(cmd.ExecuteScalar());
                }
                conexao.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }

        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            if (tb_codprod.Text != string.Empty)
            {
                pegarvalorcompra();
                MessageBox.Show("Busca realizada com sucesso");
                tb_margemdelucro.Focus();
            }
            else
            {
                backupBusca buscar = new backupBusca(this);
                buscar.ShowDialog();
                tb_codprod.Text = codigo.ToString();
                pegarvalorcompra();
                MessageBox.Show("Busca realizada com sucesso");
                tb_margemdelucro.Focus();
            }
            
        }

        private void tb_codprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }
    }
}
