namespace Projeto_Petshop.view
{
    partial class relatoriofechamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(relatoriofechamento));
            this.lv_fechar = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.totalvenda = new System.Windows.Forms.ColumnHeader();
            this.formapagamento = new System.Windows.Forms.ColumnHeader();
            this.bt_gerarelatorio = new System.Windows.Forms.Button();
            this.tb_abertura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_fechamento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_valorcaixa = new System.Windows.Forms.Label();
            this.lb_balanco = new System.Windows.Forms.Label();
            this.bt_pdf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_fechar
            // 
            this.lv_fechar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.totalvenda,
            this.formapagamento});
            this.lv_fechar.HideSelection = false;
            this.lv_fechar.Location = new System.Drawing.Point(12, 66);
            this.lv_fechar.Name = "lv_fechar";
            this.lv_fechar.Size = new System.Drawing.Size(677, 400);
            this.lv_fechar.TabIndex = 0;
            this.lv_fechar.UseCompatibleStateImageBehavior = false;
            this.lv_fechar.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 100;
            // 
            // totalvenda
            // 
            this.totalvenda.Text = "Valor total";
            this.totalvenda.Width = 150;
            // 
            // formapagamento
            // 
            this.formapagamento.Text = "Forma de Pagamento";
            this.formapagamento.Width = 150;
            // 
            // bt_gerarelatorio
            // 
            this.bt_gerarelatorio.Location = new System.Drawing.Point(449, 9);
            this.bt_gerarelatorio.Name = "bt_gerarelatorio";
            this.bt_gerarelatorio.Size = new System.Drawing.Size(100, 23);
            this.bt_gerarelatorio.TabIndex = 1;
            this.bt_gerarelatorio.Text = "Gerar relatório";
            this.bt_gerarelatorio.UseVisualStyleBackColor = true;
            this.bt_gerarelatorio.Click += new System.EventHandler(this.bt_gerarelatorio_Click);
            // 
            // tb_abertura
            // 
            this.tb_abertura.Location = new System.Drawing.Point(95, 9);
            this.tb_abertura.Name = "tb_abertura";
            this.tb_abertura.Size = new System.Drawing.Size(123, 23);
            this.tb_abertura.TabIndex = 2;
            this.tb_abertura.TextChanged += new System.EventHandler(this.tb_abertura_TextChanged);
            this.tb_abertura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_abertura_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Abertura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(237, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fechamento:";
            // 
            // tb_fechamento
            // 
            this.tb_fechamento.Location = new System.Drawing.Point(343, 9);
            this.tb_fechamento.Name = "tb_fechamento";
            this.tb_fechamento.Size = new System.Drawing.Size(100, 23);
            this.tb_fechamento.TabIndex = 5;
            this.tb_fechamento.TextChanged += new System.EventHandler(this.tb_fechamento_TextChanged);
            this.tb_fechamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_fechamento_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soma ativos: R$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(406, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Balanço: R$";
            // 
            // lb_valorcaixa
            // 
            this.lb_valorcaixa.AutoSize = true;
            this.lb_valorcaixa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_valorcaixa.Location = new System.Drawing.Point(171, 41);
            this.lb_valorcaixa.Name = "lb_valorcaixa";
            this.lb_valorcaixa.Size = new System.Drawing.Size(44, 19);
            this.lb_valorcaixa.TabIndex = 8;
            this.lb_valorcaixa.Text = "       ";
            // 
            // lb_balanco
            // 
            this.lb_balanco.AutoSize = true;
            this.lb_balanco.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_balanco.Location = new System.Drawing.Point(505, 44);
            this.lb_balanco.Name = "lb_balanco";
            this.lb_balanco.Size = new System.Drawing.Size(54, 19);
            this.lb_balanco.TabIndex = 9;
            this.lb_balanco.Text = "         ";
            // 
            // bt_pdf
            // 
            this.bt_pdf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_pdf.BackColor = System.Drawing.Color.Transparent;
            this.bt_pdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_pdf.BackgroundImage")));
            this.bt_pdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_pdf.Location = new System.Drawing.Point(635, 9);
            this.bt_pdf.Name = "bt_pdf";
            this.bt_pdf.Size = new System.Drawing.Size(54, 46);
            this.bt_pdf.TabIndex = 25;
            this.bt_pdf.UseVisualStyleBackColor = false;
            this.bt_pdf.Click += new System.EventHandler(this.bt_pdf_Click);
            // 
            // relatoriofechamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(701, 485);
            this.Controls.Add(this.bt_pdf);
            this.Controls.Add(this.lb_balanco);
            this.Controls.Add(this.lb_valorcaixa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_fechamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_abertura);
            this.Controls.Add(this.bt_gerarelatorio);
            this.Controls.Add(this.lv_fechar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "relatoriofechamento";
            this.Text = "relatorio de fechamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_fechar;
        private System.Windows.Forms.Button bt_gerarelatorio;
        private System.Windows.Forms.TextBox tb_abertura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_fechamento;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader totalvenda;
        private System.Windows.Forms.ColumnHeader formapagamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_valorcaixa;
        private System.Windows.Forms.Label lb_balanco;
        private System.Windows.Forms.Button bt_pdf;
    }
}