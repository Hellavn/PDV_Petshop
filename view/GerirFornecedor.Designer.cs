
namespace Projeto_Petshop.view
{
    partial class GerirFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirFornecedor));
            this.button_cadastrarfornecedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_nomefornecedor = new System.Windows.Forms.TextBox();
            this.textBox_endfornecedor = new System.Windows.Forms.TextBox();
            this.textBox_emailfornecedor = new System.Windows.Forms.TextBox();
            this.TextBox_telfornecedor = new System.Windows.Forms.MaskedTextBox();
            this.TextBox_cnpjfornecedor = new System.Windows.Forms.MaskedTextBox();
            this.listView_fornecedor = new System.Windows.Forms.ListView();
            this.li_idfornecedor = new System.Windows.Forms.ColumnHeader();
            this.lv_nomefornecedor = new System.Windows.Forms.ColumnHeader();
            this.lv_cidadefornecedor = new System.Windows.Forms.ColumnHeader();
            this.lv_endfornecedor = new System.Windows.Forms.ColumnHeader();
            this.lv_emailfornecedor = new System.Windows.Forms.ColumnHeader();
            this.lv_telfornecedor = new System.Windows.Forms.ColumnHeader();
            this.lv_cnpjfornecedor = new System.Windows.Forms.ColumnHeader();
            this.estadoFornecedor = new System.Windows.Forms.ColumnHeader();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_cidadefornecedor = new System.Windows.Forms.TextBox();
            this.button_editarfornecedor = new System.Windows.Forms.Button();
            this.button_excluirfornecedor = new System.Windows.Forms.Button();
            this.cbEstadoFornecedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_cadastrarfornecedor
            // 
            this.button_cadastrarfornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_cadastrarfornecedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_cadastrarfornecedor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_cadastrarfornecedor.Location = new System.Drawing.Point(145, 406);
            this.button_cadastrarfornecedor.Name = "button_cadastrarfornecedor";
            this.button_cadastrarfornecedor.Size = new System.Drawing.Size(142, 32);
            this.button_cadastrarfornecedor.TabIndex = 0;
            this.button_cadastrarfornecedor.Text = "Cadastrar";
            this.button_cadastrarfornecedor.UseVisualStyleBackColor = false;
            this.button_cadastrarfornecedor.Click += new System.EventHandler(this.button_cadastrarfornecedor_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(386, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefone: ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(207, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "CNPJ:";
            // 
            // textBox_nomefornecedor
            // 
            this.textBox_nomefornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_nomefornecedor.Location = new System.Drawing.Point(87, 46);
            this.textBox_nomefornecedor.Name = "textBox_nomefornecedor";
            this.textBox_nomefornecedor.Size = new System.Drawing.Size(600, 23);
            this.textBox_nomefornecedor.TabIndex = 6;
            // 
            // textBox_endfornecedor
            // 
            this.textBox_endfornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_endfornecedor.Location = new System.Drawing.Point(108, 82);
            this.textBox_endfornecedor.Name = "textBox_endfornecedor";
            this.textBox_endfornecedor.Size = new System.Drawing.Size(579, 23);
            this.textBox_endfornecedor.TabIndex = 7;
            // 
            // textBox_emailfornecedor
            // 
            this.textBox_emailfornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_emailfornecedor.Location = new System.Drawing.Point(459, 116);
            this.textBox_emailfornecedor.Name = "textBox_emailfornecedor";
            this.textBox_emailfornecedor.Size = new System.Drawing.Size(228, 23);
            this.textBox_emailfornecedor.TabIndex = 8;
            // 
            // TextBox_telfornecedor
            // 
            this.TextBox_telfornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_telfornecedor.Location = new System.Drawing.Point(100, 147);
            this.TextBox_telfornecedor.Mask = "(00) 00000-0000";
            this.TextBox_telfornecedor.Name = "TextBox_telfornecedor";
            this.TextBox_telfornecedor.Size = new System.Drawing.Size(101, 23);
            this.TextBox_telfornecedor.TabIndex = 9;
            // 
            // TextBox_cnpjfornecedor
            // 
            this.TextBox_cnpjfornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_cnpjfornecedor.Location = new System.Drawing.Point(271, 146);
            this.TextBox_cnpjfornecedor.Mask = "00,000,000/0000-00";
            this.TextBox_cnpjfornecedor.Name = "TextBox_cnpjfornecedor";
            this.TextBox_cnpjfornecedor.Size = new System.Drawing.Size(108, 23);
            this.TextBox_cnpjfornecedor.TabIndex = 10;
            // 
            // listView_fornecedor
            // 
            this.listView_fornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView_fornecedor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.li_idfornecedor,
            this.lv_nomefornecedor,
            this.lv_cidadefornecedor,
            this.lv_endfornecedor,
            this.lv_emailfornecedor,
            this.lv_telfornecedor,
            this.lv_cnpjfornecedor,
            this.estadoFornecedor});
            this.listView_fornecedor.HideSelection = false;
            this.listView_fornecedor.Location = new System.Drawing.Point(12, 177);
            this.listView_fornecedor.Name = "listView_fornecedor";
            this.listView_fornecedor.Size = new System.Drawing.Size(675, 223);
            this.listView_fornecedor.TabIndex = 11;
            this.listView_fornecedor.UseCompatibleStateImageBehavior = false;
            this.listView_fornecedor.View = System.Windows.Forms.View.Details;
            this.listView_fornecedor.SelectedIndexChanged += new System.EventHandler(this.listView_fornecedor_SelectedIndexChanged);
            // 
            // li_idfornecedor
            // 
            this.li_idfornecedor.Text = "ID";
            this.li_idfornecedor.Width = 40;
            // 
            // lv_nomefornecedor
            // 
            this.lv_nomefornecedor.Text = "Nome";
            this.lv_nomefornecedor.Width = 150;
            // 
            // lv_cidadefornecedor
            // 
            this.lv_cidadefornecedor.Text = "Cidade";
            this.lv_cidadefornecedor.Width = 80;
            // 
            // lv_endfornecedor
            // 
            this.lv_endfornecedor.Text = "Endereço";
            this.lv_endfornecedor.Width = 80;
            // 
            // lv_emailfornecedor
            // 
            this.lv_emailfornecedor.Text = "E-mail";
            this.lv_emailfornecedor.Width = 80;
            // 
            // lv_telfornecedor
            // 
            this.lv_telfornecedor.Text = "Telefone";
            // 
            // lv_cnpjfornecedor
            // 
            this.lv_cnpjfornecedor.Text = "CNPJ";
            this.lv_cnpjfornecedor.Width = 80;
            // 
            // estadoFornecedor
            // 
            this.estadoFornecedor.Text = "Estado";
            this.estadoFornecedor.Width = 100;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cidade";
            // 
            // textBox_cidadefornecedor
            // 
            this.textBox_cidadefornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_cidadefornecedor.Location = new System.Drawing.Point(87, 112);
            this.textBox_cidadefornecedor.Name = "textBox_cidadefornecedor";
            this.textBox_cidadefornecedor.Size = new System.Drawing.Size(301, 23);
            this.textBox_cidadefornecedor.TabIndex = 13;
            // 
            // button_editarfornecedor
            // 
            this.button_editarfornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_editarfornecedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_editarfornecedor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_editarfornecedor.Location = new System.Drawing.Point(307, 406);
            this.button_editarfornecedor.Name = "button_editarfornecedor";
            this.button_editarfornecedor.Size = new System.Drawing.Size(142, 32);
            this.button_editarfornecedor.TabIndex = 14;
            this.button_editarfornecedor.Text = "Editar";
            this.button_editarfornecedor.UseVisualStyleBackColor = false;
            this.button_editarfornecedor.Click += new System.EventHandler(this.button_editarfornecedor_Click);
            // 
            // button_excluirfornecedor
            // 
            this.button_excluirfornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_excluirfornecedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_excluirfornecedor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_excluirfornecedor.Location = new System.Drawing.Point(464, 406);
            this.button_excluirfornecedor.Name = "button_excluirfornecedor";
            this.button_excluirfornecedor.Size = new System.Drawing.Size(142, 32);
            this.button_excluirfornecedor.TabIndex = 15;
            this.button_excluirfornecedor.Text = "Excluir";
            this.button_excluirfornecedor.UseVisualStyleBackColor = false;
            this.button_excluirfornecedor.Click += new System.EventHandler(this.button_excluirfornecedor_Click);
            // 
            // cbEstadoFornecedor
            // 
            this.cbEstadoFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbEstadoFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoFornecedor.FormattingEnabled = true;
            this.cbEstadoFornecedor.Items.AddRange(new object[] {
            "Ativado",
            "Desativado"});
            this.cbEstadoFornecedor.Location = new System.Drawing.Point(459, 148);
            this.cbEstadoFornecedor.Name = "cbEstadoFornecedor";
            this.cbEstadoFornecedor.Size = new System.Drawing.Size(228, 23);
            this.cbEstadoFornecedor.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(385, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Estado:";
            // 
            // GerirFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(699, 457);
            this.Controls.Add(this.cbEstadoFornecedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_excluirfornecedor);
            this.Controls.Add(this.button_editarfornecedor);
            this.Controls.Add(this.textBox_cidadefornecedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listView_fornecedor);
            this.Controls.Add(this.TextBox_cnpjfornecedor);
            this.Controls.Add(this.TextBox_telfornecedor);
            this.Controls.Add(this.textBox_emailfornecedor);
            this.Controls.Add(this.textBox_endfornecedor);
            this.Controls.Add(this.textBox_nomefornecedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cadastrarfornecedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerirFornecedor";
            this.Text = "Gerir fornecedor";
            this.Load += new System.EventHandler(this.GerirFornecedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cadastrarfornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_nomefornecedor;
        private System.Windows.Forms.TextBox textBox_endfornecedor;
        private System.Windows.Forms.TextBox textBox_emailfornecedor;
        private System.Windows.Forms.MaskedTextBox TextBox_telfornecedor;
        private System.Windows.Forms.MaskedTextBox TextBox_cnpjfornecedor;
        private System.Windows.Forms.ListView listView_fornecedor;
        private System.Windows.Forms.ColumnHeader li_idfornecedor;
        private System.Windows.Forms.ColumnHeader lv_nomefornecedor;
        private System.Windows.Forms.ColumnHeader lv_cidadefornecedor;
        private System.Windows.Forms.ColumnHeader lv_endfornecedor;
        private System.Windows.Forms.ColumnHeader lv_emailfornecedor;
        private System.Windows.Forms.ColumnHeader lv_telfornecedor;
        private System.Windows.Forms.ColumnHeader lv_cnpjfornecedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_cidadefornecedor;
        private System.Windows.Forms.Button button_editarfornecedor;
        private System.Windows.Forms.Button button_excluirfornecedor;
        private System.Windows.Forms.ComboBox cbEstadoFornecedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader estadoFornecedor;
    }
}