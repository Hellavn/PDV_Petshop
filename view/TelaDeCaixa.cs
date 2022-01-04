using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace Projeto_Petshop.view
{
    public partial class TelaDeCaixa : Form
    {
        

        public int codigo = -1;
        public double totalcompra = 0;
        public int qtdEstoque = 0;
        public int id_usuario = 0;
        public string senha;
        public string blote;
        public string bfornecedor;
        public int id_venda = -1;
        public string nomeusuario;
        public double valortroco = 0;
        public double SOMA = 0;

        public double valorsemdesc = 0;
        public bool dardesc;
        public double qtddesc;

        public int tc_idcliente;
        public string tc_nomecliente;
        public string tc_cpfcliente;
        public int tc_quantidadecompra;

        

        public Boolean ativarfidelidade = false;

        public TelaDeCaixa()
        {
            InitializeComponent();
        }
        public TelaDeCaixa(BuscarProdutoEstoque buscar)
        {
            InitializeComponent();
        }

        public TelaDeCaixa(CPFcliente cpfcliente)
        {
            InitializeComponent();
        }

        public TelaDeCaixa(int usuario)
        {
            this.id_usuario = usuario;
            InitializeComponent();
            carregaridvenda();
        }
        private void TelaDeCaixa_Load(object sender, EventArgs e)
        {

        }
        public void Limpar()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Text = string.Empty;
                if (c is CheckBox)
                    ((CheckBox)c).Checked = false;
                if (c is ComboBox)
                    ((ComboBox)c).Text = string.Empty;
                lb_marca.Text = "";
                lb_valoruni.Text = "";
                lb_nome.Text = "";
                cb_fornecedor.Text = null;
                cb_lote.Text = null;
                tb_troco.Enabled = false;
            }
        }
        public void PegarFornecedorLote()
        {
            if (codigo != -1) 
            {
                try
                {
                    Conexao con = new Conexao();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select * from fornecedor_produto where id_produto = @cod";
                    cmd.Parameters.AddWithValue("@cod", codigo);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con.Conectar();
             
                    SqlDataReader pegar = cmd.ExecuteReader();
                    cb_fornecedor.Items.Clear();
                    cb_lote.Items.Clear();
                    while (pegar.Read())
                    {
                        cb_fornecedor.Items.Add(pegar.GetInt32(2).ToString() + " - " + pegar.GetString(8));
                        cb_lote.Items.Add(pegar.GetString(3));
                    }
                    con.Desconectar();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Erro ao se conectar ao banco de dados");
                }
            }   
        }

        public void realizarbusca()
        {
            try
            {
                Conexao con = new Conexao();
                SqlCommand cmd = new SqlCommand();
                codigo = int.Parse(tb_codprod.Text);
                cmd.Parameters.AddWithValue("@cod", codigo);
                cmd.CommandText = "select * from produto where id_produto = @cod";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con.Conectar();
                SqlDataReader produto = cmd.ExecuteReader();
                lb_nome.Text = "";
                lb_marca.Text = "";
                lb_valoruni.Text = "";
                while (produto.Read())
                {
                    lb_nome.Text = produto.GetString(1);
                    lb_marca.Text = produto.GetString(3);
                    lb_valoruni.Text = ("R$ " + produto.GetDouble(2).ToString("F2"));
                }
                con.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
            PegarFornecedorLote();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // botão de busca
            if (tb_codprod.Text != string.Empty)
            {
                realizarbusca();
            }
            else
            {
                BuscarProdutoEstoque buscar = new BuscarProdutoEstoque(this);
                buscar.ShowDialog();
                tb_codprod.Text = codigo.ToString();
                cb_lote.Text = blote;
                cb_fornecedor.Text = bfornecedor;
                realizarbusca();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (tb_codprod.Text != string.Empty && tb_qtd.Text != string.Empty && cb_fornecedor.Text != string.Empty && cb_lote.Text != string.Empty)
            {
                    carregarlv();
            }
            else
            {
                if(tb_codprod.Text == string.Empty)
                {
                    MessageBox.Show("Favor preencher o código do produto.");
                }
                else
                {
                    if(tb_qtd.Text == string.Empty || int.Parse(tb_qtd.Text) <= 0)
                    {
                        MessageBox.Show("Favor informar a quantidade correta de produtos.");
                    }
                    else
                    {
                        if (cb_fornecedor.Text == string.Empty)
                        {
                            MessageBox.Show("Favor informar o fornecedor");
                        }
                        else 
                        {
                            MessageBox.Show("Favor informar o lote.");
                        }
                    }
                }
            }
        }
        public void carregarlv()
        {
            lv_venda.LabelEdit = true;
            lv_venda.AllowColumnReorder = true;
            lv_venda.FullRowSelect = true;
            if ((lb_nome.Text != string.Empty && lb_marca.Text != string.Empty))
            {
                try
                {
                    Conexao con = new Conexao();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select * from fornecedor_produto where id_produto = @cod and lote = @lote and id_fornecedor = @fornecedor";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con.Conectar();
                    codigo = int.Parse(tb_codprod.Text);
                    string[] fornecedor = cb_fornecedor.Text.Split(" - ");
                    cmd.Parameters.AddWithValue("@cod", codigo);
                    cmd.Parameters.AddWithValue("@lote", cb_lote.Text);
                    cmd.Parameters.AddWithValue("@fornecedor", int.Parse(fornecedor[0]));
                    string[] preco = lb_valoruni.Text.Split("R$ ");
                    SOMA = int.Parse(tb_qtd.Text) * double.Parse(preco[1]);
                    SqlDataReader produto = cmd.ExecuteReader();
                    while (produto.Read())
                    {
                        qtdEstoque = produto.GetInt32(4);
                        if (qtdEstoque >= int.Parse(tb_qtd.Text)) { 
                            var lv = new ListViewItem(produto.GetInt32(0).ToString());   //id fornecedor_produto
                            lv.SubItems.Add(produto.GetInt32(1).ToString());             //id_produto
                            lv.SubItems.Add(produto.GetString(7));                       //nome produto
                            lv.SubItems.Add(produto.GetString(3));                       //lote          
                            lv.SubItems.Add(tb_qtd.Text);                                //quantidade
                            lv.SubItems.Add(SOMA.ToString("F2"));                            //valor
                            lv.SubItems.Add(produto.GetInt32(2).ToString());             //id_fornecedor
                            lv.SubItems.Add(produto.GetString(8));                       //nome_fornecedor
                            lv_venda.Items.Add(lv);
                            totalcompra = totalcompra + SOMA;
                        }
                        else
                        {
                            MessageBox.Show("Não existe quantidade de produto o suficiente em estoque. " + qtdEstoque);
                        }
                    }
                    con.Desconectar();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Erro ao buscar no banco de dados!!!");
                }
                lb_valortotal.Text = totalcompra.ToString("F2");
                Limpar();
            }
            else
            {
                MessageBox.Show("Informações de produto inconsistentes, favor clicar no botão 'Buscar' novamente.");
            }
        }
        private void bt_menu_Click(object sender, EventArgs e)
        {  
            CPFcliente cpfcliente = new CPFcliente(this);  
            cpfcliente.ShowDialog();
            if (dardesc)
            {
                valorsemdesc = double.Parse(lb_valortotal.Text);
                qtddesc = double.Parse(lb_valortotal.Text) * 0.1;
                lb_valortotal.Text = (valorsemdesc - qtddesc).ToString("F2");
            }
        }
        private void bt_remover_Click(object sender, EventArgs e)
        {
            //sub 5
            totalcompra = totalcompra - double.Parse(lv_venda.SelectedItems[0].SubItems[5].Text);
            lb_valortotal.Text = totalcompra.ToString("F2");
            lv_venda.Items.Remove(lv_venda.SelectedItems[0]);

           
        }

        public void dardesconto()
        {
            if (dardesc)
            {
                
                try
                {
                    Conexao con = new Conexao();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@cpf", tc_cpfcliente);
                    cmd.CommandText = "update cliente set qtd_compras = 0 where cpf_cliente = @cpf";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();

                    con.Desconectar();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Erro ao reinicar fidelidado do cliente");
                }
            }
            else
            {
                if (ativarfidelidade)
                {
                    try
                    {
                        Conexao con = new Conexao();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Parameters.AddWithValue("@cpf", tc_cpfcliente);
                        cmd.CommandText = "update cliente set qtd_compras = (qtd_compras+1) where cpf_cliente = @cpf";
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con.Conectar();
                        cmd.ExecuteNonQuery();

                        con.Desconectar();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Erro ao reinicar fidelidado do cliente");
                    }
                }
            }
        }

        public void finalizardesconto()
        {
            if (dardesc)
            {

                try
                {
                    Conexao con = new Conexao();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@id_venda", id_venda);
                    cmd.CommandText = "update venda set fidelidade = 1 where id_venda = @id_venda";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();

                    con.Desconectar();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Erro ao cadastrar o desconto na venda.");
                }
            }
        }

        private void bt_finaliza_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Finalizar venda?", "ALERTA", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
               
                if (cb_formapagamento.Text != string.Empty)
                {
                    if (cb_formapagamento.Text == "Dinheiro")
                    {
                        
                        string[] troco = tb_troco.Text.Split("R$");
                        if (double.Parse(troco[1])>= double.Parse(lb_valortotal.Text))
                        {
                            valortroco = double.Parse(troco[1]) - double.Parse(lb_valortotal.Text);
                            MessageBox.Show("Valor troco: R$" + valortroco.ToString("F2"));
                            
                        }
                        else
                        {
                            if (double.Parse(troco[1]) == double.Parse(lb_valortotal.Text))
                            {
                                MessageBox.Show("Valor informado é o mesmo da compra, não é necessário troco.");
                            }
                            else
                            {
                                MessageBox.Show("Valor informado não cobre o valor da compra");
                            }
                        }                         
                    }
                    dardesconto();
                    //finalizar compra 
                    FinalizarCompra compra = new FinalizarCompra();
                    compra.efetuar_venda(lb_valortotal.Text, cb_formapagamento.Text, id_usuario);
                    for (int i=0; i < lv_venda.Items.Count; i++)
                    {
                        FinalizarCompra itens = new FinalizarCompra();
                        itens.itens(int.Parse(lv_venda.Items[i].SubItems[1].Text),      //int id_produto
                                    int.Parse(lv_venda.Items[i].SubItems[4].Text),      //int quantidade_itens
                                    double.Parse(lv_venda.Items[i].SubItems[5].Text),   //double valor_total_itens
                                    lv_venda.Items[i].SubItems[3].Text,                 //string lote
                                    lv_venda.Items[i].SubItems[2].Text,                 //string nome_produto
                                    int.Parse(lv_venda.Items[i].SubItems[6].Text),      //int id_fornecedor
                                    lv_venda.Items[i].SubItems[7].Text);                //string nome_fornecedor
                        //id_produto, lote, id_fornecedor, quantidade
                        FinalizarCompra baixa = new FinalizarCompra();
                        baixa.darBaixa(int.Parse(lv_venda.Items[i].SubItems[1].Text), lv_venda.Items[i].SubItems[3].Text, int.Parse(lv_venda.Items[i].SubItems[6].Text), int.Parse(lv_venda.Items[i].SubItems[4].Text));
                    }
                    MessageBox.Show(compra.exibir_mensagem);
                    
                    GerarRelatorio();
                    finalizardesconto();
                    
                    lv_venda.Items.Clear();
                    lb_valortotal.Text = "";
                    valortroco = 0;
                    SOMA = 0;
                    totalcompra = 0;
                    valorsemdesc = 0;
                    dardesc = false;
                    qtddesc = 0;

                    tc_idcliente = 0;
                    tc_nomecliente = "";
                    tc_cpfcliente = "";
                    tc_quantidadecompra = 0;
                   
                    carregaridvenda();
                }
                else
                {
                    MessageBox.Show("Favor informar forma de pagamento.");
                }
            }
            
        }
        private void tb_codprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void tb_qtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        public void GerarRelatorio()
        {
            // cria o documento (227, 400) para cupom fiscal, para a4 (pagesize.A4)
            Document relatorio = new Document(new iTextSharp.text.Rectangle(227,400));
            //seta as margens da pagina
            relatorio.SetMargins(5,5,5,5);
           
            relatorio.AddCreationDate();
            // cria o diretoria
            string diretorio = @"D:\relatoriosprojeto\caixa\venda_" + id_venda+ ".pdf";
            
            //salva o arquivo
            PdfWriter salvar = PdfWriter.GetInstance(relatorio, new FileStream(diretorio, FileMode.Create));

            // abrir relatorio para edita-lo
            relatorio.Open();
            // ---------------------------------------------------------------------------------------------//
            // gerar paragrafo
            Paragraph nomeempresa = new Paragraph();
            
            // define fonte do paragrafo
            nomeempresa.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 5);
            nomeempresa.Alignment = Element.ALIGN_CENTER;
            // definir espaçamento entre linhas
            nomeempresa.SetLeading(1, 1);
            nomeempresa.Add("Nipon Pet Center \n");
            relatorio.Add(nomeempresa);

            // --------------------------------------------------------------------------------------------//

            Paragraph titulovenda = new Paragraph();

            // define fonte do paragrafo
            titulovenda.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10);
            titulovenda.Alignment = Element.ALIGN_CENTER;
            // definir espaçamento entre linhas
            titulovenda.SetLeading(1, 1);
            titulovenda.Add("Venda: " + id_venda + "\n\n");
            relatorio.Add(titulovenda);

            // --------------------------------------------------------------------------------------------//
            PdfPTable itensvenda = new PdfPTable(3);
            itensvenda.DefaultCell.Border = 0;
            itensvenda.WidthPercentage = 100;
            double valortotalform = double.Parse(lb_valortotal.Text);
            var fontecelula = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 7);
            itensvenda.AddCell(new Phrase("Produto", fontecelula));
            itensvenda.AddCell(new Phrase("Quantidade", fontecelula));
            itensvenda.AddCell(new Phrase("Preço: R$", fontecelula));
            for (int i = 0; i < lv_venda.Items.Count; i++)
            {
                itensvenda.AddCell(new Phrase(lv_venda.Items[i].SubItems[2].Text, fontecelula)); // nome
                itensvenda.AddCell(new Phrase(lv_venda.Items[i].SubItems[4].Text, fontecelula)); // quantidade
                itensvenda.AddCell(new Phrase(lv_venda.Items[i].SubItems[5].Text, fontecelula)); // preço de cada produto
            }
            itensvenda.AddCell(new Phrase("Total: ", fontecelula));
            itensvenda.AddCell(new Phrase("", fontecelula));
            itensvenda.AddCell(new Phrase(" R$" + valortotalform.ToString("F2"), fontecelula));
            relatorio.Add(itensvenda);
            //---------------------------------------------------------------------------------------------//

            Paragraph paragrafovazio = new Paragraph();

            // definir espaçamento entre linhas
            paragrafovazio.SetLeading(1, 1);
            paragrafovazio.Add(" ");
            paragrafovazio.Add(" ");
            relatorio.Add(paragrafovazio);

            //---------------------------------------------------------------------------------------------//
            PegarUsuario(); // função para pegar o nome do usuario com base no id_usuario
            var data = DateTime.Today.ToString("dd-MM-yyyy"); // função para pegar a data atual

            PdfPTable informacoesvenda = new PdfPTable(3);
            informacoesvenda.DefaultCell.Border = 0;
            informacoesvenda.WidthPercentage = 100;
            informacoesvenda.AddCell(new Phrase("Operador: " + nomeusuario, fontecelula)); // nome
            informacoesvenda.AddCell(new Phrase("Data: " + data, fontecelula)); // quantidade
            informacoesvenda.AddCell(new Phrase(cb_formapagamento.Text, fontecelula)); // preço de cada produto

            relatorio.Add(informacoesvenda);
            // -------------------------------------------------------------------------------------------- //

            //paragrafovazio
            relatorio.Add(paragrafovazio);

            //---------------------------------------------------------------------------------------------//
            if (dardesc)
            {
                PdfPTable informacoesdesconto = new PdfPTable(3);
                informacoesdesconto.DefaultCell.Border = 0;
                informacoesdesconto.WidthPercentage = 100;
                informacoesdesconto.AddCell(new Phrase("Nome do Cliente: " + tc_nomecliente, fontecelula)); 
                informacoesdesconto.AddCell(new Phrase("CPF: " + tc_cpfcliente, fontecelula)); 
                informacoesdesconto.AddCell(new Phrase("Valor do desconto: R$" + qtddesc.ToString("F2"), fontecelula)); 

                relatorio.Add(informacoesdesconto);
            }
            // -------------------------------------------------------------------------------------------- //

            //paragrafovazio
            relatorio.Add(paragrafovazio);
            //paragrafovazio
            relatorio.Add(paragrafovazio);
            //paragrafovazio
            relatorio.Add(paragrafovazio);


            PdfPTable cupomsemvalorfiscal = new PdfPTable(3);
            cupomsemvalorfiscal.DefaultCell.Border = 0;
            cupomsemvalorfiscal.WidthPercentage = 100;
            cupomsemvalorfiscal.AddCell(new Phrase("" + tc_nomecliente, fontecelula)); // nome
            cupomsemvalorfiscal.AddCell(new Phrase("Cupom sem valor fiscal", fontecelula)); // quantidade
            cupomsemvalorfiscal.AddCell(new Phrase("", fontecelula)); // preço de cada produto

            relatorio.Add(cupomsemvalorfiscal);
            // -------------------------------------------------------------------------------------------- //
            relatorio.Close();
            valortotalform = 0;
        }
        public void carregaridvenda()
        {
            try
            {
                Conexao conexao = new Conexao();
                //Comando SQL --SqlCommand
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select MAX(id_venda) from venda";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexao.Conectar();
                if (cmd.ExecuteScalar() == DBNull.Value)
                {
                    id_venda = 1;
                }
                else
                {
                    id_venda = Convert.ToInt32(cmd.ExecuteScalar()) + 1;  
                }
                conexao.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
        }
        private void cb_formapagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_formapagamento.Text == "Dinheiro")
            {
                tb_troco.Enabled = true;
            }
            else
            {
                tb_troco.Enabled = false;
                tb_troco.Text = string.Empty;
            }
        }

        private void tb_troco_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref tb_troco);
        }

        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;

            try
            {
                
                n = txt.Text.Replace("R$ ", "").Replace(",", "").Replace(".", "");

                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
               
                txt.Text = string.Format("{0:C2}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }
        }

        public void PegarUsuario()
        {
            if (id_usuario != 0)
            {
                try
                {
                    Conexao con = new Conexao();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@cod", id_usuario);
                    cmd.CommandText = "select * from usuario where id_usuario = @cod";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con.Conectar();

                    SqlDataReader pegar = cmd.ExecuteReader();
                    
                    while (pegar.Read())
                    {
                        nomeusuario = pegar.GetString(1);
                    }
                    con.Desconectar();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Erro ao se conectar ao banco de dados");
                }
            }
            else
            {
                MessageBox.Show("Está sendo possível entrar no programa sem as informações do usuario");
            }
        }

        private void tb_qtd_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_troco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }
    }
}
