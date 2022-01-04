
namespace Projeto_Petshop.view
{
    partial class Relatoriomarcaoucategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatoriomarcaoucategoria));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lv_relatorio = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.marca = new System.Windows.Forms.ColumnHeader();
            this.quantidade = new System.Windows.Forms.ColumnHeader();
            this.Valorvendido = new System.Windows.Forms.ColumnHeader();
            this.check_marca = new System.Windows.Forms.CheckBox();
            this.check_categoria = new System.Windows.Forms.CheckBox();
            this.bt_pdf = new System.Windows.Forms.Button();
            this.bt_gerar = new System.Windows.Forms.Button();
            this.cal_inicial = new System.Windows.Forms.MonthCalendar();
            this.cal_final = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Qual relatório deseja criar?";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(741, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data Final:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(412, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data inicial:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lv_relatorio
            // 
            this.lv_relatorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lv_relatorio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.marca,
            this.quantidade,
            this.Valorvendido});
            this.lv_relatorio.HideSelection = false;
            this.lv_relatorio.Location = new System.Drawing.Point(15, 181);
            this.lv_relatorio.Name = "lv_relatorio";
            this.lv_relatorio.Size = new System.Drawing.Size(1076, 448);
            this.lv_relatorio.TabIndex = 13;
            this.lv_relatorio.UseCompatibleStateImageBehavior = false;
            this.lv_relatorio.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 80;
            // 
            // marca
            // 
            this.marca.Text = "Marca";
            this.marca.Width = 200;
            // 
            // quantidade
            // 
            this.quantidade.Text = "quantidade";
            this.quantidade.Width = 100;
            // 
            // Valorvendido
            // 
            this.Valorvendido.Text = "Valor vendido";
            this.Valorvendido.Width = 150;
            // 
            // check_marca
            // 
            this.check_marca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.check_marca.AutoSize = true;
            this.check_marca.Location = new System.Drawing.Point(219, 14);
            this.check_marca.Name = "check_marca";
            this.check_marca.Size = new System.Drawing.Size(72, 25);
            this.check_marca.TabIndex = 14;
            this.check_marca.Text = "Marca";
            this.check_marca.UseVisualStyleBackColor = true;
            this.check_marca.CheckedChanged += new System.EventHandler(this.v_CheckedChanged);
            // 
            // check_categoria
            // 
            this.check_categoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.check_categoria.AutoSize = true;
            this.check_categoria.Location = new System.Drawing.Point(309, 12);
            this.check_categoria.Name = "check_categoria";
            this.check_categoria.Size = new System.Drawing.Size(96, 25);
            this.check_categoria.TabIndex = 15;
            this.check_categoria.Text = "Categoria";
            this.check_categoria.UseVisualStyleBackColor = true;
            this.check_categoria.CheckedChanged += new System.EventHandler(this.check_categoria_CheckedChanged);
            // 
            // bt_pdf
            // 
            this.bt_pdf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_pdf.BackColor = System.Drawing.Color.Transparent;
            this.bt_pdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_pdf.BackgroundImage")));
            this.bt_pdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_pdf.Location = new System.Drawing.Point(1037, 638);
            this.bt_pdf.Name = "bt_pdf";
            this.bt_pdf.Size = new System.Drawing.Size(54, 46);
            this.bt_pdf.TabIndex = 17;
            this.bt_pdf.UseVisualStyleBackColor = false;
            this.bt_pdf.Click += new System.EventHandler(this.bt_pdf_Click_1);
            // 
            // bt_gerar
            // 
            this.bt_gerar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_gerar.Location = new System.Drawing.Point(346, 638);
            this.bt_gerar.Name = "bt_gerar";
            this.bt_gerar.Size = new System.Drawing.Size(209, 46);
            this.bt_gerar.TabIndex = 16;
            this.bt_gerar.Text = "Gerar relatório";
            this.bt_gerar.UseVisualStyleBackColor = true;
            this.bt_gerar.Click += new System.EventHandler(this.bt_gerar_Click);
            // 
            // cal_inicial
            // 
            this.cal_inicial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cal_inicial.Location = new System.Drawing.Point(501, 13);
            this.cal_inicial.Name = "cal_inicial";
            this.cal_inicial.TabIndex = 18;
            // 
            // cal_final
            // 
            this.cal_final.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cal_final.Location = new System.Drawing.Point(825, 12);
            this.cal_final.Name = "cal_final";
            this.cal_final.TabIndex = 19;
            // 
            // Relatoriomarcaoucategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1103, 696);
            this.Controls.Add(this.cal_final);
            this.Controls.Add(this.cal_inicial);
            this.Controls.Add(this.bt_pdf);
            this.Controls.Add(this.bt_gerar);
            this.Controls.Add(this.check_categoria);
            this.Controls.Add(this.check_marca);
            this.Controls.Add(this.lv_relatorio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Relatoriomarcaoucategoria";
            this.Text = "Relatorio de venda por marca/categoria";
            this.Load += new System.EventHandler(this.Relatoriomarcaoucategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lv_relatorio;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader marca;
        private System.Windows.Forms.ColumnHeader quantidade;
        private System.Windows.Forms.ColumnHeader Valorvendido;
        private System.Windows.Forms.CheckBox check_marca;
        private System.Windows.Forms.CheckBox check_categoria;
        private System.Windows.Forms.Button bt_pdf;
        private System.Windows.Forms.Button bt_gerar;
        private System.Windows.Forms.MonthCalendar cal_inicial;
        private System.Windows.Forms.MonthCalendar cal_final;
    }
}