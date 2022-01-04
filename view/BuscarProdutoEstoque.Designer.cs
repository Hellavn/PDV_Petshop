
namespace Projeto_Petshop.view
{
    partial class BuscarProdutoEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarProdutoEstoque));
            this.label5 = new System.Windows.Forms.Label();
            this.tbLote = new System.Windows.Forms.TextBox();
            this.tbFornecedor = new System.Windows.Forms.TextBox();
            this.lv_pesquisa = new System.Windows.Forms.ListView();
            this.colID = new System.Windows.Forms.ColumnHeader();
            this.colNome = new System.Windows.Forms.ColumnHeader();
            this.ColFornecedor = new System.Windows.Forms.ColumnHeader();
            this.colLote = new System.Windows.Forms.ColumnHeader();
            this.bt_pesquisar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(76, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 43;
            this.label5.Text = "Lote:";
            // 
            // tbLote
            // 
            this.tbLote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbLote.Location = new System.Drawing.Point(12, 206);
            this.tbLote.Name = "tbLote";
            this.tbLote.Size = new System.Drawing.Size(182, 23);
            this.tbLote.TabIndex = 35;
            this.tbLote.TextChanged += new System.EventHandler(this.tbLote_TextChanged_1);
            // 
            // tbFornecedor
            // 
            this.tbFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFornecedor.Location = new System.Drawing.Point(12, 158);
            this.tbFornecedor.Name = "tbFornecedor";
            this.tbFornecedor.Size = new System.Drawing.Size(182, 23);
            this.tbFornecedor.TabIndex = 42;
            this.tbFornecedor.TextChanged += new System.EventHandler(this.tbFornecedor_TextChanged_1);
            // 
            // lv_pesquisa
            // 
            this.lv_pesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lv_pesquisa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colNome,
            this.ColFornecedor,
            this.colLote});
            this.lv_pesquisa.HideSelection = false;
            this.lv_pesquisa.Location = new System.Drawing.Point(200, 78);
            this.lv_pesquisa.Name = "lv_pesquisa";
            this.lv_pesquisa.Size = new System.Drawing.Size(521, 284);
            this.lv_pesquisa.TabIndex = 41;
            this.lv_pesquisa.UseCompatibleStateImageBehavior = false;
            this.lv_pesquisa.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 35;
            // 
            // colNome
            // 
            this.colNome.Text = "Nome";
            this.colNome.Width = 150;
            // 
            // ColFornecedor
            // 
            this.ColFornecedor.Text = "Fornecedor";
            this.ColFornecedor.Width = 120;
            // 
            // colLote
            // 
            this.colLote.Text = "Lote";
            this.colLote.Width = 100;
            // 
            // bt_pesquisar
            // 
            this.bt_pesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_pesquisar.Location = new System.Drawing.Point(50, 235);
            this.bt_pesquisar.Name = "bt_pesquisar";
            this.bt_pesquisar.Size = new System.Drawing.Size(83, 23);
            this.bt_pesquisar.TabIndex = 39;
            this.bt_pesquisar.Text = "Pesquisar";
            this.bt_pesquisar.UseVisualStyleBackColor = true;
            this.bt_pesquisar.Click += new System.EventHandler(this.bt_pesquisar_Click_1);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(62, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 19);
            this.label6.TabIndex = 38;
            this.label6.Text = "Fornecedor:";
            // 
            // tb_nome
            // 
            this.tb_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_nome.Location = new System.Drawing.Point(12, 110);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(182, 23);
            this.tb_nome.TabIndex = 37;
            this.tb_nome.TextChanged += new System.EventHandler(this.tb_nome_TextChanged_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(76, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(222, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Buscar Produto em Estoque";
            // 
            // BuscarProdutoEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(732, 394);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbLote);
            this.Controls.Add(this.tbFornecedor);
            this.Controls.Add(this.lv_pesquisa);
            this.Controls.Add(this.bt_pesquisar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscarProdutoEstoque";
            this.Text = "Buscar Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLote;
        private System.Windows.Forms.TextBox tbFornecedor;
        private System.Windows.Forms.ListView lv_pesquisa;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colNome;
        private System.Windows.Forms.ColumnHeader ColFornecedor;
        private System.Windows.Forms.ColumnHeader colLote;
        private System.Windows.Forms.Button bt_pesquisar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}