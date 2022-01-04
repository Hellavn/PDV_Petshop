namespace Projeto_Petshop.view
{
    partial class Relatorio_produtocombaixoestoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio_produtocombaixoestoque));
            this.lv_relatorio = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.nomeproduto = new System.Windows.Forms.ColumnHeader();
            this.Nomefornecedor = new System.Windows.Forms.ColumnHeader();
            this.quantidade = new System.Windows.Forms.ColumnHeader();
            this.marca = new System.Windows.Forms.ColumnHeader();
            this.bt_pdf = new System.Windows.Forms.Button();
            this.bt_gerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_relatorio
            // 
            this.lv_relatorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lv_relatorio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.nomeproduto,
            this.Nomefornecedor,
            this.quantidade,
            this.marca});
            this.lv_relatorio.HideSelection = false;
            this.lv_relatorio.Location = new System.Drawing.Point(12, 74);
            this.lv_relatorio.Name = "lv_relatorio";
            this.lv_relatorio.Size = new System.Drawing.Size(895, 563);
            this.lv_relatorio.TabIndex = 10;
            this.lv_relatorio.UseCompatibleStateImageBehavior = false;
            this.lv_relatorio.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 80;
            // 
            // nomeproduto
            // 
            this.nomeproduto.Text = "Nome do Produto";
            this.nomeproduto.Width = 200;
            // 
            // Nomefornecedor
            // 
            this.Nomefornecedor.Text = "Fornecedor";
            this.Nomefornecedor.Width = 200;
            // 
            // quantidade
            // 
            this.quantidade.Text = "quantidade";
            this.quantidade.Width = 100;
            // 
            // marca
            // 
            this.marca.Text = "Marca";
            this.marca.Width = 100;
            // 
            // bt_pdf
            // 
            this.bt_pdf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_pdf.BackColor = System.Drawing.Color.DarkGray;
            this.bt_pdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_pdf.BackgroundImage")));
            this.bt_pdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_pdf.Location = new System.Drawing.Point(566, 12);
            this.bt_pdf.Name = "bt_pdf";
            this.bt_pdf.Size = new System.Drawing.Size(50, 46);
            this.bt_pdf.TabIndex = 13;
            this.bt_pdf.UseVisualStyleBackColor = false;
            this.bt_pdf.Click += new System.EventHandler(this.bt_pdf_Click);
            // 
            // bt_gerar
            // 
            this.bt_gerar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_gerar.Location = new System.Drawing.Point(351, 12);
            this.bt_gerar.Name = "bt_gerar";
            this.bt_gerar.Size = new System.Drawing.Size(209, 46);
            this.bt_gerar.TabIndex = 12;
            this.bt_gerar.Text = "Gerar relatório";
            this.bt_gerar.UseVisualStyleBackColor = true;
            this.bt_gerar.Click += new System.EventHandler(this.bt_gerar_Click);
            // 
            // Relatorio_produtocombaixoestoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(919, 649);
            this.Controls.Add(this.bt_pdf);
            this.Controls.Add(this.bt_gerar);
            this.Controls.Add(this.lv_relatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Relatorio_produtocombaixoestoque";
            this.Text = "Relatório de produtos com baixo estoque";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_relatorio;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader quantidade;
        private System.Windows.Forms.ColumnHeader nomeproduto;
        private System.Windows.Forms.ColumnHeader marca;
        private System.Windows.Forms.Button bt_pdf;
        private System.Windows.Forms.Button bt_gerar;
        private System.Windows.Forms.ColumnHeader Nomefornecedor;
    }
}