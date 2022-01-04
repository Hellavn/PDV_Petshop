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
    public partial class CPFcliente : Form
    {
        
        public TelaDeCaixa telacaixa;

        public int idcliente;
        public string nomecliente;
        public string cpfcliente;
        public int quantidadecompra;
        public bool dardesconto = false;
        bool existelinha = false;
        


        public CPFcliente(TelaDeCaixa tc)
        {
            InitializeComponent();
            telacaixa = tc;
           
        }
        public CPFcliente()
        {
            InitializeComponent();
        }

        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            verificarcpf();
            if (existelinha)
            {
                MessageBox.Show("Cliente encontrado.");
                DialogResult dialogResult = MessageBox.Show("Aplicar desconto?", "ALERTA", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (quantidadecompra < 10)
                    {
                        dardesconto = false;
                        MessageBox.Show("Cliente não possui compras o suficiente ainda para aplicação de desconto. faltam: " 
                            + (10-quantidadecompra) + " compras direito a desconto.");
                    }
                    else
                    {
                        if (quantidadecompra == 10)
                        {
                            dardesconto = true;
                        }
                    }
                    telacaixa.tc_idcliente = idcliente;
                    telacaixa.tc_nomecliente = nomecliente;
                    telacaixa.tc_cpfcliente = cpfcliente;
                    telacaixa.tc_quantidadecompra = quantidadecompra;
                    telacaixa.dardesc = dardesconto;
                    telacaixa.ativarfidelidade = true;
                    this.Close();
                }
                else
                {
                    this.Close();
                }
                    
            }
        }
        public bool verificarcpf()
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@cpf", tb_cpfcliente.Text);
                cmd.CommandText = "select * from cliente where cpf_cliente = @cpf";

                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexao.Conectar();
                SqlDataReader retorno = cmd.ExecuteReader();
                if (retorno.HasRows)
                {

                    while (retorno.Read())
                    {
                        idcliente = retorno.GetInt32(0);
                        nomecliente = retorno.GetString(1);
                        cpfcliente = retorno.GetString(2);
                        quantidadecompra = retorno.GetInt32(7);
                    }
                    existelinha = true;
                }
                else
                {
                    MessageBox.Show("CPF não cadastrado.");
                }
                conexao.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("CPF não cadastrado.");
            }
            return existelinha;
        }

        private void tb_cpfcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }
    }
}
