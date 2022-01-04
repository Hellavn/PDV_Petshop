
namespace Projeto_Petshop.view
{
    partial class TelaDeCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeCaixa));
            this.label1 = new System.Windows.Forms.Label();
            this.lv_venda = new System.Windows.Forms.ListView();
            this.cod_fornecedorproduto = new System.Windows.Forms.ColumnHeader();
            this.id_produto = new System.Windows.Forms.ColumnHeader();
            this.nome_produto = new System.Windows.Forms.ColumnHeader();
            this.lote = new System.Windows.Forms.ColumnHeader();
            this.qtd_produto = new System.Windows.Forms.ColumnHeader();
            this.valor = new System.Windows.Forms.ColumnHeader();
            this.id_fornecedor = new System.Windows.Forms.ColumnHeader();
            this.nome_fornecedor = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_codprod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_qtd = new System.Windows.Forms.TextBox();
            this.lb_marca = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_lote = new System.Windows.Forms.ComboBox();
            this.cb_fornecedor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_valoruni = new System.Windows.Forms.Label();
            this.lb_valortotal = new System.Windows.Forms.Label();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_remover = new System.Windows.Forms.Button();
            this.bt_finaliza = new System.Windows.Forms.Button();
            this.bt_desconto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_formapagamento = new System.Windows.Forms.ComboBox();
            this.tb_troco = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caixa";
            // 
            // lv_venda
            // 
            this.lv_venda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lv_venda.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lv_venda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_venda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cod_fornecedorproduto,
            this.id_produto,
            this.nome_produto,
            this.lote,
            this.qtd_produto,
            this.valor,
            this.id_fornecedor,
            this.nome_fornecedor});
            this.lv_venda.HideSelection = false;
            this.lv_venda.Location = new System.Drawing.Point(400, 12);
            this.lv_venda.Name = "lv_venda";
            this.lv_venda.Size = new System.Drawing.Size(677, 492);
            this.lv_venda.TabIndex = 1;
            this.lv_venda.UseCompatibleStateImageBehavior = false;
            this.lv_venda.View = System.Windows.Forms.View.Details;
            // 
            // cod_fornecedorproduto
            // 
            this.cod_fornecedorproduto.Width = 0;
            // 
            // id_produto
            // 
            this.id_produto.Text = "Id";
            // 
            // nome_produto
            // 
            this.nome_produto.Text = "Nome";
            this.nome_produto.Width = 150;
            // 
            // lote
            // 
            this.lote.Text = "Lote";
            this.lote.Width = 100;
            // 
            // qtd_produto
            // 
            this.qtd_produto.Text = "Quantidade";
            this.qtd_produto.Width = 140;
            // 
            // valor
            // 
            this.valor.Text = "valor";
            this.valor.Width = 100;
            // 
            // id_fornecedor
            // 
            this.id_fornecedor.Text = "fornecedor";
            this.id_fornecedor.Width = 0;
            // 
            // nome_fornecedor
            // 
            this.nome_fornecedor.Text = "Fornecedor";
            this.nome_fornecedor.Width = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código produto:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(8, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lote:";
            // 
            // tb_codprod
            // 
            this.tb_codprod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_codprod.Location = new System.Drawing.Point(181, 43);
            this.tb_codprod.Name = "tb_codprod";
            this.tb_codprod.Size = new System.Drawing.Size(108, 30);
            this.tb_codprod.TabIndex = 5;
            this.tb_codprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_codprod_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(8, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Produto:";
            // 
            // lb_nome
            // 
            this.lb_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_nome.AutoSize = true;
            this.lb_nome.BackColor = System.Drawing.Color.Transparent;
            this.lb_nome.Location = new System.Drawing.Point(107, 199);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(280, 23);
            this.lb_nome.TabIndex = 8;
            this.lb_nome.Text = "                                             ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(9, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Marca:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(9, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Valor unitário: R$";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(8, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Quantidade:";
            // 
            // tb_qtd
            // 
            this.tb_qtd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_qtd.Location = new System.Drawing.Point(141, 77);
            this.tb_qtd.Name = "tb_qtd";
            this.tb_qtd.Size = new System.Drawing.Size(100, 30);
            this.tb_qtd.TabIndex = 12;
            this.tb_qtd.TextChanged += new System.EventHandler(this.tb_qtd_TextChanged);
            this.tb_qtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_qtd_KeyPress);
            // 
            // lb_marca
            // 
            this.lb_marca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_marca.AutoSize = true;
            this.lb_marca.BackColor = System.Drawing.Color.Transparent;
            this.lb_marca.Location = new System.Drawing.Point(90, 232);
            this.lb_marca.Name = "lb_marca";
            this.lb_marca.Size = new System.Drawing.Size(298, 23);
            this.lb_marca.TabIndex = 13;
            this.lb_marca.Text = "                                                ";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(6, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "Valor total: R$";
            // 
            // cb_lote
            // 
            this.cb_lote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_lote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_lote.FormattingEnabled = true;
            this.cb_lote.Location = new System.Drawing.Point(78, 111);
            this.cb_lote.Name = "cb_lote";
            this.cb_lote.Size = new System.Drawing.Size(280, 31);
            this.cb_lote.TabIndex = 15;
            // 
            // cb_fornecedor
            // 
            this.cb_fornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_fornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_fornecedor.FormattingEnabled = true;
            this.cb_fornecedor.Location = new System.Drawing.Point(143, 155);
            this.cb_fornecedor.Name = "cb_fornecedor";
            this.cb_fornecedor.Size = new System.Drawing.Size(215, 31);
            this.cb_fornecedor.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(13, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 23);
            this.label10.TabIndex = 17;
            this.label10.Text = "Fornecedor:";
            // 
            // lb_valoruni
            // 
            this.lb_valoruni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_valoruni.AutoSize = true;
            this.lb_valoruni.BackColor = System.Drawing.Color.Transparent;
            this.lb_valoruni.Location = new System.Drawing.Point(195, 263);
            this.lb_valoruni.Name = "lb_valoruni";
            this.lb_valoruni.Size = new System.Drawing.Size(130, 23);
            this.lb_valoruni.TabIndex = 18;
            this.lb_valoruni.Text = "                    ";
            // 
            // lb_valortotal
            // 
            this.lb_valortotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_valortotal.AutoSize = true;
            this.lb_valortotal.BackColor = System.Drawing.Color.Transparent;
            this.lb_valortotal.Location = new System.Drawing.Point(162, 387);
            this.lb_valortotal.Name = "lb_valortotal";
            this.lb_valortotal.Size = new System.Drawing.Size(112, 23);
            this.lb_valortotal.TabIndex = 19;
            this.lb_valortotal.Text = "                 ";
            // 
            // bt_buscar
            // 
            this.bt_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_buscar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_buscar.Location = new System.Drawing.Point(307, 44);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(87, 28);
            this.bt_buscar.TabIndex = 20;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_add
            // 
            this.bt_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_add.BackColor = System.Drawing.Color.Chartreuse;
            this.bt_add.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_add.Location = new System.Drawing.Point(12, 289);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(70, 29);
            this.bt_add.TabIndex = 21;
            this.bt_add.Text = "Adicionar";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_remover
            // 
            this.bt_remover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_remover.BackColor = System.Drawing.Color.Red;
            this.bt_remover.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_remover.Location = new System.Drawing.Point(88, 289);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(84, 29);
            this.bt_remover.TabIndex = 22;
            this.bt_remover.Text = "Remover";
            this.bt_remover.UseVisualStyleBackColor = false;
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click);
            // 
            // bt_finaliza
            // 
            this.bt_finaliza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_finaliza.BackColor = System.Drawing.Color.Turquoise;
            this.bt_finaliza.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_finaliza.Location = new System.Drawing.Point(272, 470);
            this.bt_finaliza.Name = "bt_finaliza";
            this.bt_finaliza.Size = new System.Drawing.Size(122, 34);
            this.bt_finaliza.TabIndex = 23;
            this.bt_finaliza.Text = "Finalizar";
            this.bt_finaliza.UseVisualStyleBackColor = false;
            this.bt_finaliza.Click += new System.EventHandler(this.bt_finaliza_Click);
            // 
            // bt_desconto
            // 
            this.bt_desconto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_desconto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_desconto.Location = new System.Drawing.Point(9, 476);
            this.bt_desconto.Name = "bt_desconto";
            this.bt_desconto.Size = new System.Drawing.Size(75, 23);
            this.bt_desconto.TabIndex = 24;
            this.bt_desconto.Text = "Desconto";
            this.bt_desconto.UseVisualStyleBackColor = true;
            this.bt_desconto.Click += new System.EventHandler(this.bt_menu_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(9, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Forma de pagamento:";
            // 
            // cb_formapagamento
            // 
            this.cb_formapagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_formapagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_formapagamento.FormattingEnabled = true;
            this.cb_formapagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Débito",
            "Crédito"});
            this.cb_formapagamento.Location = new System.Drawing.Point(234, 350);
            this.cb_formapagamento.Name = "cb_formapagamento";
            this.cb_formapagamento.Size = new System.Drawing.Size(154, 31);
            this.cb_formapagamento.TabIndex = 26;
            this.cb_formapagamento.SelectedIndexChanged += new System.EventHandler(this.cb_formapagamento_SelectedIndexChanged);
            // 
            // tb_troco
            // 
            this.tb_troco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_troco.Enabled = false;
            this.tb_troco.Location = new System.Drawing.Point(134, 417);
            this.tb_troco.Name = "tb_troco";
            this.tb_troco.Size = new System.Drawing.Size(124, 30);
            this.tb_troco.TabIndex = 27;
            this.tb_troco.TextChanged += new System.EventHandler(this.tb_troco_TextChanged);
            this.tb_troco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_troco_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(8, 420);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 23);
            this.label11.TabIndex = 28;
            this.label11.Text = "Valor pago:";
            // 
            // TelaDeCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 516);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_troco);
            this.Controls.Add(this.cb_formapagamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_desconto);
            this.Controls.Add(this.bt_finaliza);
            this.Controls.Add(this.bt_remover);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.lb_valortotal);
            this.Controls.Add(this.lb_valoruni);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_fornecedor);
            this.Controls.Add(this.cb_lote);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lb_marca);
            this.Controls.Add(this.tb_qtd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_codprod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lv_venda);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaDeCaixa";
            this.Text = "Caixa                                ";
            this.Load += new System.EventHandler(this.TelaDeCaixa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_venda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_codprod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_qtd;
        private System.Windows.Forms.Label lb_marca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_lote;
        private System.Windows.Forms.ComboBox cb_fornecedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_valoruni;
        private System.Windows.Forms.Label lb_valortotal;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_remover;
        private System.Windows.Forms.Button bt_finaliza;
        private System.Windows.Forms.ColumnHeader cod_fornecedorproduto;
        private System.Windows.Forms.ColumnHeader id_produto;
        private System.Windows.Forms.ColumnHeader nome_produto;
        private System.Windows.Forms.ColumnHeader lote;
        private System.Windows.Forms.ColumnHeader qtd_produto;
        private System.Windows.Forms.ColumnHeader valor;
        private System.Windows.Forms.ColumnHeader id_fornecedor;
        private System.Windows.Forms.ColumnHeader nome_fornecedor;
        private System.Windows.Forms.Button bt_desconto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_formapagamento;
        private System.Windows.Forms.TextBox tb_troco;
        private System.Windows.Forms.Label label11;
    }
}