
namespace Projeto_Petshop.view
{
    partial class backupBusca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(backupBusca));
            this.lv_pesquisa = new System.Windows.Forms.ListView();
            this.colID = new System.Windows.Forms.ColumnHeader();
            this.colNome = new System.Windows.Forms.ColumnHeader();
            this.colMarca = new System.Windows.Forms.ColumnHeader();
            this.colCategoria = new System.Windows.Forms.ColumnHeader();
            this.bt_pesquisar = new System.Windows.Forms.Button();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lv_pesquisa
            // 
            this.lv_pesquisa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colNome,
            this.colMarca,
            this.colCategoria});
            this.lv_pesquisa.HideSelection = false;
            this.lv_pesquisa.Location = new System.Drawing.Point(12, 66);
            this.lv_pesquisa.Name = "lv_pesquisa";
            this.lv_pesquisa.Size = new System.Drawing.Size(760, 347);
            this.lv_pesquisa.TabIndex = 43;
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
            // colMarca
            // 
            this.colMarca.Text = "Marca";
            this.colMarca.Width = 100;
            // 
            // colCategoria
            // 
            this.colCategoria.Text = "Categoria";
            this.colCategoria.Width = 100;
            // 
            // bt_pesquisar
            // 
            this.bt_pesquisar.Location = new System.Drawing.Point(689, 37);
            this.bt_pesquisar.Name = "bt_pesquisar";
            this.bt_pesquisar.Size = new System.Drawing.Size(83, 23);
            this.bt_pesquisar.TabIndex = 41;
            this.bt_pesquisar.Text = "Pesquisar";
            this.bt_pesquisar.UseVisualStyleBackColor = true;
            this.bt_pesquisar.Click += new System.EventHandler(this.bt_pesquisar_Click_1);
            // 
            // tb_nome
            // 
            this.tb_nome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_nome.Location = new System.Drawing.Point(75, 37);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(608, 23);
            this.tb_nome.TabIndex = 40;
            this.tb_nome.TextChanged += new System.EventHandler(this.tb_nome_TextChanged_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Buscar Produto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // backupBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.lv_pesquisa);
            this.Controls.Add(this.bt_pesquisar);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "backupBusca";
            this.Text = "Buscar Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_pesquisa;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colNome;
        private System.Windows.Forms.ColumnHeader colMarca;
        private System.Windows.Forms.ColumnHeader colCategoria;
        private System.Windows.Forms.Button bt_pesquisar;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}