
namespace Projeto_Petshop.view
{
    partial class Relatorio_prodmaisvendido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio_prodmaisvendido));
            this.cb_marca = new System.Windows.Forms.ComboBox();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lv_relatorio = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.quantidade = new System.Windows.Forms.ColumnHeader();
            this.nome = new System.Windows.Forms.ColumnHeader();
            this.Valorvendido = new System.Windows.Forms.ColumnHeader();
            this.bt_gerar = new System.Windows.Forms.Button();
            this.bt_pdf = new System.Windows.Forms.Button();
            this.cal_final = new System.Windows.Forms.MonthCalendar();
            this.cal_inicial = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // cb_marca
            // 
            this.cb_marca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_marca.FormattingEnabled = true;
            this.cb_marca.Location = new System.Drawing.Point(79, 83);
            this.cb_marca.Name = "cb_marca";
            this.cb_marca.Size = new System.Drawing.Size(239, 23);
            this.cb_marca.TabIndex = 0;
            // 
            // cb_categoria
            // 
            this.cb_categoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Location = new System.Drawing.Point(79, 42);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(239, 23);
            this.cb_categoria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data inicial:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data Final:";
            // 
            // lv_relatorio
            // 
            this.lv_relatorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lv_relatorio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.quantidade,
            this.nome,
            this.Valorvendido});
            this.lv_relatorio.HideSelection = false;
            this.lv_relatorio.Location = new System.Drawing.Point(13, 179);
            this.lv_relatorio.Name = "lv_relatorio";
            this.lv_relatorio.Size = new System.Drawing.Size(906, 488);
            this.lv_relatorio.TabIndex = 9;
            this.lv_relatorio.UseCompatibleStateImageBehavior = false;
            this.lv_relatorio.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 80;
            // 
            // quantidade
            // 
            this.quantidade.Text = "quantidade";
            this.quantidade.Width = 100;
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 200;
            // 
            // Valorvendido
            // 
            this.Valorvendido.Text = "Valor vendido";
            this.Valorvendido.Width = 100;
            // 
            // bt_gerar
            // 
            this.bt_gerar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_gerar.Location = new System.Drawing.Point(79, 112);
            this.bt_gerar.Name = "bt_gerar";
            this.bt_gerar.Size = new System.Drawing.Size(239, 27);
            this.bt_gerar.TabIndex = 10;
            this.bt_gerar.Text = "Gerar relatório";
            this.bt_gerar.UseVisualStyleBackColor = true;
            this.bt_gerar.Click += new System.EventHandler(this.bt_gerar_Click);
            // 
            // bt_pdf
            // 
            this.bt_pdf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_pdf.BackColor = System.Drawing.Color.Transparent;
            this.bt_pdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_pdf.BackgroundImage")));
            this.bt_pdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_pdf.Location = new System.Drawing.Point(324, 112);
            this.bt_pdf.Name = "bt_pdf";
            this.bt_pdf.Size = new System.Drawing.Size(37, 32);
            this.bt_pdf.TabIndex = 11;
            this.bt_pdf.UseVisualStyleBackColor = false;
            this.bt_pdf.Click += new System.EventHandler(this.bt_pdf_Click);
            // 
            // cal_final
            // 
            this.cal_final.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cal_final.Location = new System.Drawing.Point(692, 5);
            this.cal_final.Name = "cal_final";
            this.cal_final.TabIndex = 12;
            // 
            // cal_inicial
            // 
            this.cal_inicial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cal_inicial.Location = new System.Drawing.Point(390, 5);
            this.cal_inicial.Name = "cal_inicial";
            this.cal_inicial.TabIndex = 13;
            // 
            // Relatorio_prodmaisvendido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(931, 731);
            this.Controls.Add(this.cal_inicial);
            this.Controls.Add(this.cal_final);
            this.Controls.Add(this.bt_pdf);
            this.Controls.Add(this.bt_gerar);
            this.Controls.Add(this.lv_relatorio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_categoria);
            this.Controls.Add(this.cb_marca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Relatorio_prodmaisvendido";
            this.Text = "Relatório produto mais vendido";
            this.Load += new System.EventHandler(this.Relatorio_prodmaisvendido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_marca;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lv_relatorio;
        private System.Windows.Forms.Button bt_gerar;
        private System.Windows.Forms.Button bt_pdf;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader quantidade;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader Valorvendido;
        private System.Windows.Forms.MonthCalendar cal_final;
        private System.Windows.Forms.MonthCalendar cal_inicial;
    }
}