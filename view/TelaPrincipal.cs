using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Petshop.view
{
    public partial class TelaPrincipal : Form
    {
        public string funcao = "";
        public int id_usuario = 0;
        public bool existelinhaestoque = false;
        public bool botaoestoque = false;

        public bool existelinhavencimento = false;
        public bool botaovencimento = false;

        public TelaPrincipal()
        {
            InitializeComponent();
            verificarBaixoEstoque();
            verificarvencimento();
        }
        
        public TelaPrincipal(string valor, int usuario)
        {
            this.funcao = valor;
            this.id_usuario = usuario;
            InitializeComponent();
            verificarBaixoEstoque();
            if (funcao.Equals("Vendedor"))
            {
                categoriaMenu.Enabled = false;
                fornecedoresToolStripMenuItem.Enabled = false;
                usuáriosToolStripMenuItem.Enabled = false;    
                produtosMenu.Enabled = false;   
                relatórioDeProdutosComBaixoEstoqueToolStripMenuItem.Enabled = false;
                relatórioDeVencimentoDeProdutoToolStripMenuItem.Enabled = false;
                relatórioDeVendaPorCategoriaToolStripMenuItem.Enabled = false;
                caixaToolStripMenuItem.Enabled = false; 
                relatórioDeVendasPorMarcasubMenu.Enabled = false;   
                relatórioDeVendasPorPeriodoToolStripMenuItem.Enabled = false;   
                relatórioDeVendasPorPeriodoToolStripMenuItem.Enabled=false; 
                relatórioDeVendaPorCategoriaToolStripMenuItem.Enabled  =false;
                gerirEstoqueToolStripMenuItem.Enabled = false;
                estoque.Enabled = false;
                bt_baixoestoque.Enabled = false;
                bt_produtosvencidos.Enabled = false;
                marcaToolStripMenuItem.Enabled = false;
                gerirClientesToolStripMenuItem.Enabled = true;
                fechamentosubmenu.Enabled = false;  

                categoriaMenu.Visible = false;
                fornecedoresToolStripMenuItem.Visible = false;
                usuáriosToolStripMenuItem.Visible = false;
                produtosMenu.Visible = false;
                relatórioDeProdutosComBaixoEstoqueToolStripMenuItem.Visible = false;
                relatórioDeVencimentoDeProdutoToolStripMenuItem.Visible = false;
                relatórioDeVendaPorCategoriaToolStripMenuItem.Visible = false;
                caixaToolStripMenuItem.Visible = false;
                relatórioDeVendasPorMarcasubMenu.Visible = false;
                relatórioDeVendasPorPeriodoToolStripMenuItem.Visible = false;
                relatórioDeVendasPorPeriodoToolStripMenuItem.Visible = false;
                relatórioDeVendaPorCategoriaToolStripMenuItem.Visible = false;
                gerirEstoqueToolStripMenuItem.Visible = false;
                estoque.Visible = false;
                bt_baixoestoque.Visible = false;
                bt_produtosvencidos.Visible = false;
                gerirClientesToolStripMenuItem.Visible = true;
                marcaToolStripMenuItem.Visible = false;
                fechamentosubmenu.Visible = false;
            }

            if (funcao.Equals("Caixa"))
            {
                categoriaMenu.Enabled = false;
                fornecedoresToolStripMenuItem.Enabled = false;
                usuáriosToolStripMenuItem.Enabled = false;
                produtosMenu.Enabled = false;
                relatórioDeProdutosComBaixoEstoqueToolStripMenuItem.Enabled = false;
                relatórioDeVencimentoDeProdutoToolStripMenuItem.Enabled = false;
                relatórioDeVendaPorCategoriaToolStripMenuItem.Enabled = false;
                relatórioDeVendasPorMarcasubMenu.Enabled = false;
                relatórioDeVendasPorPeriodoToolStripMenuItem.Enabled = false;
                relatórioDeVendasPorPeriodoToolStripMenuItem.Enabled = false;
                relatórioDeVendaPorCategoriaToolStripMenuItem.Enabled = false;
                gerirEstoqueToolStripMenuItem.Enabled = false;
                estoque.Enabled = false;
                bt_baixoestoque.Enabled = false;
                bt_produtosvencidos.Enabled = false;
                fechamentosubmenu.Enabled = false;  

                categoriaMenu.Visible = false;
                fornecedoresToolStripMenuItem.Visible = false;
                usuáriosToolStripMenuItem.Visible = false;
                produtosMenu.Visible = false;
                relatórioDeProdutosComBaixoEstoqueToolStripMenuItem.Visible = false;
                relatórioDeVencimentoDeProdutoToolStripMenuItem.Visible = false;
                relatórioDeVendaPorCategoriaToolStripMenuItem.Visible = false;
                relatórioDeVendasPorMarcasubMenu.Visible = false;
                relatórioDeVendasPorPeriodoToolStripMenuItem.Visible = false;
                relatórioDeVendasPorPeriodoToolStripMenuItem.Visible = false;
                relatórioDeVendaPorCategoriaToolStripMenuItem.Visible = false;
                gerirEstoqueToolStripMenuItem.Visible = false;
                estoque.Visible = false;
                bt_baixoestoque.Visible = false;
                bt_produtosvencidos.Visible = false;
                fechamentosubmenu.Visible = false;
            }
        }
     
        private void gerirCategoriasubmenu_Click(object sender, EventArgs e)
        {
            if (funcao.Equals("Gerente"))
            {
                GerirCategoria categoria = new GerirCategoria();
                categoria.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não possui permissão para isso.");
            }
        }

        private void gerirMarcasubmenu_Click(object sender, EventArgs e)
        {
            if (funcao.Equals("Gerente"))
            {
                GerirMarca marca = new GerirMarca();
                marca.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não possui permissão para isso.");
            }
        }

        private void gerirProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (funcao.Equals("Gerente"))
            {
                GerirProduto produto = new GerirProduto();
                produto.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não possui permissão para isso.");
            }
        }

        private void caixaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (funcao.Equals("Gerente") || funcao.Equals("Caixa"))
            {
                TelaDeCaixa caixa = new TelaDeCaixa(id_usuario);
                caixa.ShowDialog();

            }
            else
            {
                MessageBox.Show("Você não possui permissão para isso.");
            }
        }

        private void gerirClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (funcao.Equals("Gerente") || funcao.Equals("Vendedor"))
            {
                GerirCliente cliente = new GerirCliente();
                cliente.ShowDialog();

            }
            else
            {
                MessageBox.Show("Você não possui permissão para isso.");
            }
        }

        private void gerirUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (funcao.Equals("Gerente"))
            {
                GerirUsuario usuario = new GerirUsuario();
                usuario.ShowDialog();

            }
            else
            {
                MessageBox.Show("Você não possui permissão para isso.");
            }
        }

        private void gerirFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (funcao.Equals("Gerente"))
            {
                GerirFornecedor fornecedor = new GerirFornecedor();
                fornecedor.ShowDialog();

            }
            else
            {
                MessageBox.Show("Você não possui permissão para isso.");
            }
        }

        private void relatórioDeVendasPorPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (funcao.Equals("Gerente"))
            {
                RelatorioVendaPorPeriodo relatorio = new RelatorioVendaPorPeriodo();
                relatorio.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não possui permissão para isso.");
            }
        }

        private void relatórioDeProdutosComBaixoEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (funcao.Equals("Gerente"))
            {
                Relatorio_produtocombaixoestoque relatorio = new Relatorio_produtocombaixoestoque();
                relatorio.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não possui permissão para isso.");
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaLogin login = new telaLogin();
            this.Close();
            login.ShowDialog();
            
        }

        private void gerirEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (funcao.Equals("Gerente") || funcao.Equals("Vendedor"))
            {
                Estoque estoque = new Estoque();
                estoque.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não possui permissão para isso.");
            }
        }

        private void relatórioDeVencimentoDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (funcao.Equals("Gerente"))
            {
                Relatorio_vencimentoprod relatorio = new Relatorio_vencimentoprod();
                relatorio.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não possui permissão para isso.");
            }
        }

        private void relatórioDeProdutosMaisVendidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (funcao.Equals("Gerente"))
            {
                Relatorio_prodmaisvendido relatorio = new Relatorio_prodmaisvendido();
                relatorio.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não possui permissão para isso.");
            }
        }

        private void relatórioDeVendasPorMarcasubMenu_Click(object sender, EventArgs e)
        {
            if (funcao.Equals("Gerente"))
            {
                Relatoriomarcaoucategoria relatorio = new Relatoriomarcaoucategoria();
                relatorio.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não possui permissão para isso.");
            }
        }

        private void relatórioDeVendaPorCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (funcao.Equals("Gerente"))
            {
                Relatoriomarcaoucategoria relatorio = new Relatoriomarcaoucategoria();
                relatorio.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não possui permissão para isso.");
            }
        }

        public void verificarBaixoEstoque()
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select e.id_fornecedor_produto, e.nome_produto, e.nome_fornecedor, e.quantidade_produto, p.marca from fornecedor_produto as e " +
                                   "inner join produto as p on e.id_produto = p.id_produto " +
                                   "where e.quantidade_produto < 30 " +
                                    "order by quantidade_produto asc";

                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexao.Conectar();
                SqlDataReader produto = cmd.ExecuteReader();
                if (produto.HasRows)
                {
                    existelinhaestoque = true;
                }
                conexao.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Não foi possível verificar quantidade de produto em estoque!");
            }
            if (existelinhaestoque)
            {
                Timer Tempo = new Timer();
                Tempo.Interval = 2000;
                Tempo.Tick += new EventHandler(timer1_Tick);
                Tempo.Start();
            }
        }
        public void verificarvencimento()
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand();
                //string dias = "30";
                //cmd.Parameters.AddWithValue("@dias", dias);
              
                cmd.CommandText = "select * from fornecedor_produto " +
                "where (DATEDIFF(DAY, datavalidade, GETDATE())) < 30 " +
                "order by datavalidade asc";

                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexao.Conectar();
                SqlDataReader produto = cmd.ExecuteReader();
                if (produto.HasRows)
                {
                    existelinhavencimento = true;
                   
                }
                conexao.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Não foi possível verificar quantidade de produto em estoque!");
            }
            if (existelinhavencimento)
            {
                Timer Tempo1 = new Timer();
                Tempo1.Interval = 2000;
                Tempo1.Tick += new EventHandler(timer2_Tick);
                Tempo1.Start();
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (existelinhaestoque && botaoestoque == false)
            {
                if (bt_baixoestoque.BackColor == Color.White)
                {
                    bt_baixoestoque.BackColor = Color.Green;
                    bt_baixoestoque.ForeColor = Color.Black;
                }
                else
                {
                    bt_baixoestoque.BackColor = Color.White;
                    bt_baixoestoque.ForeColor = Color.Black;
                }
            }
            else
            {
                timer1.Enabled = false;
                bt_baixoestoque.Visible = false;
             
            }

        }

        private void bt_baixoestoque_Click(object sender, EventArgs e)
        {
            botaoestoque = true;
           
            if (funcao.Equals("Gerente"))
            {
                Relatorio_produtocombaixoestoque relatorio = new Relatorio_produtocombaixoestoque();
                relatorio.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não possui permissão para isso.");
            }



        }

        private void vendaPorMarcacategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caminho = @"D:\projeto II doc\manual _do_usuario.pdf";
            try
            {
                Process myProcess = new Process();
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = caminho;
                myProcess.Start();
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void fechamentosubmenu_Click(object sender, EventArgs e)
        {
            

            if (funcao.Equals("Gerente"))
            {
                relatoriofechamento relatorio = new relatoriofechamento();
                relatorio.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não possui permissão para isso.");
            }
        }

        private void bt_produtosvencidos_Click(object sender, EventArgs e)
        {
            
            timer2.Enabled = false;
            bt_produtosvencidos.Visible = false;

            if (funcao.Equals("Gerente"))
            {
                Relatorio_vencimentoprod relatorio = new Relatorio_vencimentoprod();
                relatorio.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não possui permissão para isso.");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (existelinhavencimento )
            {
                if (bt_produtosvencidos.BackColor == Color.White)
                {
                    bt_produtosvencidos.BackColor = Color.Green;
                    bt_produtosvencidos.ForeColor = Color.Black;
                }
                else
                {
                    bt_produtosvencidos.BackColor = Color.White;
                    bt_produtosvencidos.ForeColor = Color.Black;
                }
            }
            
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            verificarvencimento();
        }

        private void configurarMargemDeLucroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (funcao.Equals("Gerente"))
            {
                MargemLucro relatorio = new MargemLucro();
                relatorio.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não possui permissão para isso.");
            }
        }
    }
}
