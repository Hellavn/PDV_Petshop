
namespace Projeto_Petshop
{
    partial class Estoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estoque));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label100 = new System.Windows.Forms.Label();
            this.label_nome = new System.Windows.Forms.Label();
            this.label_marca = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_qtdprod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_codigoprod = new System.Windows.Forms.TextBox();
            this.button_buscar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.calendario_fabricacao = new System.Windows.Forms.MonthCalendar();
            this.calendario_validade = new System.Windows.Forms.MonthCalendar();
            this.button_Add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_lote = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_fornecedor = new System.Windows.Forms.ComboBox();
            this.listView_produto = new System.Windows.Forms.ListView();
            this.id_tabela = new System.Windows.Forms.ColumnHeader();
            this.idprod = new System.Windows.Forms.ColumnHeader();
            this.idfornecedor = new System.Windows.Forms.ColumnHeader();
            this.nome_prod = new System.Windows.Forms.ColumnHeader();
            this.lote = new System.Windows.Forms.ColumnHeader();
            this.fornecedor = new System.Windows.Forms.ColumnHeader();
            this.qtdEst0que = new System.Windows.Forms.ColumnHeader();
            this.Preco = new System.Windows.Forms.ColumnHeader();
            this.preco_venda = new System.Windows.Forms.ColumnHeader();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPrecoCompra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_precoproduto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do produto:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // Label100
            // 
            this.Label100.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label100.AutoSize = true;
            this.Label100.BackColor = System.Drawing.Color.Transparent;
            this.Label100.Location = new System.Drawing.Point(9, 88);
            this.Label100.Name = "Label100";
            this.Label100.Size = new System.Drawing.Size(64, 19);
            this.Label100.TabIndex = 2;
            this.Label100.Text = "Marca:";
            // 
            // label_nome
            // 
            this.label_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_nome.AutoSize = true;
            this.label_nome.BackColor = System.Drawing.Color.Transparent;
            this.label_nome.Location = new System.Drawing.Point(78, 59);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(124, 19);
            this.label_nome.TabIndex = 3;
            this.label_nome.Text = "                       ";
            // 
            // label_marca
            // 
            this.label_marca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_marca.AutoSize = true;
            this.label_marca.BackColor = System.Drawing.Color.Transparent;
            this.label_marca.Location = new System.Drawing.Point(80, 91);
            this.label_marca.Name = "label_marca";
            this.label_marca.Size = new System.Drawing.Size(164, 19);
            this.label_marca.TabIndex = 4;
            this.label_marca.Text = "                               ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(8, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade de produtos:";
            // 
            // textBox_qtdprod
            // 
            this.textBox_qtdprod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_qtdprod.Location = new System.Drawing.Point(225, 109);
            this.textBox_qtdprod.Name = "textBox_qtdprod";
            this.textBox_qtdprod.Size = new System.Drawing.Size(100, 27);
            this.textBox_qtdprod.TabIndex = 6;
            this.textBox_qtdprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_qtdprod_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(331, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lote:";
            // 
            // textBox_codigoprod
            // 
            this.textBox_codigoprod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_codigoprod.Location = new System.Drawing.Point(181, 18);
            this.textBox_codigoprod.Name = "textBox_codigoprod";
            this.textBox_codigoprod.Size = new System.Drawing.Size(100, 27);
            this.textBox_codigoprod.TabIndex = 9;
            // 
            // button_buscar
            // 
            this.button_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_buscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_buscar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_buscar.Location = new System.Drawing.Point(287, 22);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(75, 23);
            this.button_buscar.TabIndex = 10;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = false;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(879, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Data de fabricação:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(879, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Data de validade:";
            // 
            // calendario_fabricacao
            // 
            this.calendario_fabricacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calendario_fabricacao.Location = new System.Drawing.Point(879, 176);
            this.calendario_fabricacao.Name = "calendario_fabricacao";
            this.calendario_fabricacao.TabIndex = 15;
            // 
            // calendario_validade
            // 
            this.calendario_validade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calendario_validade.Location = new System.Drawing.Point(879, 391);
            this.calendario_validade.MinDate = new System.DateTime(2021, 11, 18, 0, 0, 0, 0);
            this.calendario_validade.Name = "calendario_validade";
            this.calendario_validade.TabIndex = 16;
            // 
            // button_Add
            // 
            this.button_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Add.Location = new System.Drawing.Point(9, 569);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(100, 28);
            this.button_Add.TabIndex = 17;
            this.button_Add.Text = "Adicionar";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(120, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 28);
            this.button1.TabIndex = 18;
            this.button1.Text = "Remover";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_lote
            // 
            this.comboBox_lote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_lote.FormattingEnabled = true;
            this.comboBox_lote.Location = new System.Drawing.Point(388, 142);
            this.comboBox_lote.Name = "comboBox_lote";
            this.comboBox_lote.Size = new System.Drawing.Size(386, 27);
            this.comboBox_lote.TabIndex = 19;
            this.comboBox_lote.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(8, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Fornecedor";
            // 
            // comboBox_fornecedor
            // 
            this.comboBox_fornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_fornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_fornecedor.FormattingEnabled = true;
            this.comboBox_fornecedor.Location = new System.Drawing.Point(114, 142);
            this.comboBox_fornecedor.Name = "comboBox_fornecedor";
            this.comboBox_fornecedor.Size = new System.Drawing.Size(211, 27);
            this.comboBox_fornecedor.TabIndex = 21;
            // 
            // listView_produto
            // 
            this.listView_produto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView_produto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_tabela,
            this.idprod,
            this.idfornecedor,
            this.nome_prod,
            this.lote,
            this.fornecedor,
            this.qtdEst0que,
            this.Preco,
            this.preco_venda});
            this.listView_produto.HideSelection = false;
            this.listView_produto.Location = new System.Drawing.Point(8, 175);
            this.listView_produto.Name = "listView_produto";
            this.listView_produto.Size = new System.Drawing.Size(859, 388);
            this.listView_produto.TabIndex = 22;
            this.listView_produto.UseCompatibleStateImageBehavior = false;
            this.listView_produto.View = System.Windows.Forms.View.Details;
            this.listView_produto.SelectedIndexChanged += new System.EventHandler(this.listView_produto_SelectedIndexChanged);
            this.listView_produto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_produto_MouseClick);
            // 
            // id_tabela
            // 
            this.id_tabela.Text = "id";
            // 
            // idprod
            // 
            this.idprod.Text = "ID";
            // 
            // idfornecedor
            // 
            this.idfornecedor.Text = "id fornecedor";
            this.idfornecedor.Width = 0;
            // 
            // nome_prod
            // 
            this.nome_prod.Text = "Nome";
            this.nome_prod.Width = 150;
            // 
            // lote
            // 
            this.lote.Text = "Lote";
            this.lote.Width = 100;
            // 
            // fornecedor
            // 
            this.fornecedor.Text = "fornecedor";
            this.fornecedor.Width = 150;
            // 
            // qtdEst0que
            // 
            this.qtdEst0que.Text = "Quantidade";
            this.qtdEst0que.Width = 120;
            // 
            // Preco
            // 
            this.Preco.Text = "Preco";
            this.Preco.Width = 80;
            // 
            // preco_venda
            // 
            this.preco_venda.Text = "Preço venda";
            this.preco_venda.Width = 130;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(331, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Preço de compra:";
            // 
            // tbPrecoCompra
            // 
            this.tbPrecoCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPrecoCompra.Location = new System.Drawing.Point(488, 109);
            this.tbPrecoCompra.Name = "tbPrecoCompra";
            this.tbPrecoCompra.Size = new System.Drawing.Size(102, 27);
            this.tbPrecoCompra.TabIndex = 29;
            this.tbPrecoCompra.TextChanged += new System.EventHandler(this.tbPrecoCompra_TextChanged);
            this.tbPrecoCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecoCompra_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(331, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 19);
            this.label9.TabIndex = 30;
            this.label9.Text = "Preço: R$";
            // 
            // lb_precoproduto
            // 
            this.lb_precoproduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_precoproduto.AutoSize = true;
            this.lb_precoproduto.BackColor = System.Drawing.Color.Transparent;
            this.lb_precoproduto.Location = new System.Drawing.Point(425, 87);
            this.lb_precoproduto.Name = "lb_precoproduto";
            this.lb_precoproduto.Size = new System.Drawing.Size(124, 19);
            this.lb_precoproduto.TabIndex = 31;
            this.lb_precoproduto.Text = "                       ";
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1144, 603);
            this.Controls.Add(this.lb_precoproduto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbPrecoCompra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listView_produto);
            this.Controls.Add(this.comboBox_fornecedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_lote);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.calendario_validade);
            this.Controls.Add(this.calendario_fabricacao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_buscar);
            this.Controls.Add(this.textBox_codigoprod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_qtdprod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_marca);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.Label100);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Estoque";
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.Estoque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label100;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.Label label_marca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_qtdprod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_codigoprod;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MonthCalendar calendario_fabricacao;
        private System.Windows.Forms.MonthCalendar calendario_validade;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_lote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_fornecedor;
        private System.Windows.Forms.ListView listView_produto;
        private System.Windows.Forms.ColumnHeader nome_prod;
        private System.Windows.Forms.ColumnHeader lote;
        private System.Windows.Forms.ColumnHeader fornecedor;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader id_tabela;
        private System.Windows.Forms.ColumnHeader idprod;
        private System.Windows.Forms.ColumnHeader idfornecedor;
        private System.Windows.Forms.ColumnHeader qtdEst0que;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPrecoCompra;
        private System.Windows.Forms.ColumnHeader Preco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_precoproduto;
        private System.Windows.Forms.ColumnHeader preco_venda;
    }
}