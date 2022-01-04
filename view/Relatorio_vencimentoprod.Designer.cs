
namespace Projeto_Petshop.view
{
    partial class Relatorio_vencimentoprod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio_vencimentoprod));
            this.lv_relatorio = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.nome = new System.Windows.Forms.ColumnHeader();
            this.lote = new System.Windows.Forms.ColumnHeader();
            this.datavalidade = new System.Windows.Forms.ColumnHeader();
            this.diasparavencer = new System.Windows.Forms.ColumnHeader();
            this.quantidade = new System.Windows.Forms.ColumnHeader();
            this.check_90dias = new System.Windows.Forms.CheckBox();
            this.check_60dias = new System.Windows.Forms.CheckBox();
            this.check_30dias = new System.Windows.Forms.CheckBox();
            this.check_7dias = new System.Windows.Forms.CheckBox();
            this.bt_gerar = new System.Windows.Forms.Button();
            this.bt_pdf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_relatorio
            // 
            this.lv_relatorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lv_relatorio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.nome,
            this.lote,
            this.datavalidade,
            this.diasparavencer,
            this.quantidade});
            this.lv_relatorio.HideSelection = false;
            this.lv_relatorio.Location = new System.Drawing.Point(12, 43);
            this.lv_relatorio.Name = "lv_relatorio";
            this.lv_relatorio.Size = new System.Drawing.Size(963, 609);
            this.lv_relatorio.TabIndex = 14;
            this.lv_relatorio.UseCompatibleStateImageBehavior = false;
            this.lv_relatorio.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 80;
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 200;
            // 
            // lote
            // 
            this.lote.Text = "lote";
            this.lote.Width = 150;
            // 
            // datavalidade
            // 
            this.datavalidade.Text = "Data de validade";
            this.datavalidade.Width = 100;
            // 
            // diasparavencer
            // 
            this.diasparavencer.Text = "Dias Para vencer";
            this.diasparavencer.Width = 130;
            // 
            // quantidade
            // 
            this.quantidade.Text = "quantidade";
            this.quantidade.Width = 100;
            // 
            // check_90dias
            // 
            this.check_90dias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.check_90dias.AutoSize = true;
            this.check_90dias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.check_90dias.Location = new System.Drawing.Point(266, 12);
            this.check_90dias.Name = "check_90dias";
            this.check_90dias.Size = new System.Drawing.Size(79, 25);
            this.check_90dias.TabIndex = 15;
            this.check_90dias.Text = "90 dias";
            this.check_90dias.UseVisualStyleBackColor = true;
            this.check_90dias.CheckedChanged += new System.EventHandler(this.check_90dias_CheckedChanged);
            // 
            // check_60dias
            // 
            this.check_60dias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.check_60dias.AutoSize = true;
            this.check_60dias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.check_60dias.Location = new System.Drawing.Point(351, 12);
            this.check_60dias.Name = "check_60dias";
            this.check_60dias.Size = new System.Drawing.Size(79, 25);
            this.check_60dias.TabIndex = 16;
            this.check_60dias.Text = "60 dias";
            this.check_60dias.UseVisualStyleBackColor = true;
            this.check_60dias.CheckedChanged += new System.EventHandler(this.check_60dias_CheckedChanged);
            // 
            // check_30dias
            // 
            this.check_30dias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.check_30dias.AutoSize = true;
            this.check_30dias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.check_30dias.Location = new System.Drawing.Point(436, 12);
            this.check_30dias.Name = "check_30dias";
            this.check_30dias.Size = new System.Drawing.Size(79, 25);
            this.check_30dias.TabIndex = 17;
            this.check_30dias.Text = "30 dias";
            this.check_30dias.UseVisualStyleBackColor = true;
            this.check_30dias.CheckedChanged += new System.EventHandler(this.check_30dias_CheckedChanged);
            // 
            // check_7dias
            // 
            this.check_7dias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.check_7dias.AutoSize = true;
            this.check_7dias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.check_7dias.Location = new System.Drawing.Point(521, 12);
            this.check_7dias.Name = "check_7dias";
            this.check_7dias.Size = new System.Drawing.Size(70, 25);
            this.check_7dias.TabIndex = 18;
            this.check_7dias.Text = "7 dias";
            this.check_7dias.UseVisualStyleBackColor = true;
            this.check_7dias.CheckedChanged += new System.EventHandler(this.check_7dias_CheckedChanged);
            // 
            // bt_gerar
            // 
            this.bt_gerar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_gerar.Location = new System.Drawing.Point(597, 12);
            this.bt_gerar.Name = "bt_gerar";
            this.bt_gerar.Size = new System.Drawing.Size(121, 26);
            this.bt_gerar.TabIndex = 19;
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
            this.bt_pdf.Location = new System.Drawing.Point(724, 7);
            this.bt_pdf.Name = "bt_pdf";
            this.bt_pdf.Size = new System.Drawing.Size(43, 36);
            this.bt_pdf.TabIndex = 20;
            this.bt_pdf.UseVisualStyleBackColor = false;
            this.bt_pdf.Click += new System.EventHandler(this.bt_pdf_Click);
            // 
            // Relatorio_vencimentoprod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(997, 664);
            this.Controls.Add(this.bt_pdf);
            this.Controls.Add(this.bt_gerar);
            this.Controls.Add(this.check_7dias);
            this.Controls.Add(this.check_30dias);
            this.Controls.Add(this.check_60dias);
            this.Controls.Add(this.check_90dias);
            this.Controls.Add(this.lv_relatorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Relatorio_vencimentoprod";
            this.Text = "Relatorio de produtos próximo ao vencimento";
            this.Load += new System.EventHandler(this.Relatorio_vencimentoprod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_relatorio;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader quantidade;
        private System.Windows.Forms.ColumnHeader lote;
        private System.Windows.Forms.CheckBox check_90dias;
        private System.Windows.Forms.CheckBox check_60dias;
        private System.Windows.Forms.CheckBox check_30dias;
        private System.Windows.Forms.CheckBox check_7dias;
        private System.Windows.Forms.Button bt_gerar;
        private System.Windows.Forms.ColumnHeader datavalidade;
        private System.Windows.Forms.ColumnHeader diasparavencer;
        private System.Windows.Forms.Button bt_pdf;
    }
}