
namespace Projeto_Petshop.view
{
    partial class GerirProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_nomeproduto = new System.Windows.Forms.TextBox();
            this.listView_produto = new System.Windows.Forms.ListView();
            this.cID = new System.Windows.Forms.ColumnHeader();
            this.cNome = new System.Windows.Forms.ColumnHeader();
            this.cPreco = new System.Windows.Forms.ColumnHeader();
            this.cMarca = new System.Windows.Forms.ColumnHeader();
            this.cCategoria = new System.Windows.Forms.ColumnHeader();
            this.estadoProd = new System.Windows.Forms.ColumnHeader();
            this.precoCompra = new System.Windows.Forms.ColumnHeader();
            this.comboBox_categoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_marca = new System.Windows.Forms.ComboBox();
            this.button_cadprod = new System.Windows.Forms.Button();
            this.button_editarprod = new System.Windows.Forms.Button();
            this.button_excluirpro = new System.Windows.Forms.Button();
            this.TextBox_precoproduto = new System.Windows.Forms.TextBox();
            this.cbEstadoProd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrecoCompra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkB_estado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(664, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preço:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Marca:";
            // 
            // textBox_nomeproduto
            // 
            this.textBox_nomeproduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_nomeproduto.Location = new System.Drawing.Point(84, 51);
            this.textBox_nomeproduto.Name = "textBox_nomeproduto";
            this.textBox_nomeproduto.Size = new System.Drawing.Size(819, 27);
            this.textBox_nomeproduto.TabIndex = 6;
            this.textBox_nomeproduto.TextChanged += new System.EventHandler(this.textBox_nomeproduto_TextChanged);
            // 
            // listView_produto
            // 
            this.listView_produto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView_produto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cID,
            this.cNome,
            this.cPreco,
            this.cMarca,
            this.cCategoria,
            this.estadoProd,
            this.precoCompra});
            this.listView_produto.HideSelection = false;
            this.listView_produto.Location = new System.Drawing.Point(14, 157);
            this.listView_produto.Name = "listView_produto";
            this.listView_produto.Size = new System.Drawing.Size(889, 338);
            this.listView_produto.TabIndex = 12;
            this.listView_produto.UseCompatibleStateImageBehavior = false;
            this.listView_produto.View = System.Windows.Forms.View.Details;
            this.listView_produto.SelectedIndexChanged += new System.EventHandler(this.listView_produto_SelectedIndexChanged);
            this.listView_produto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_produto_MouseClick);
            // 
            // cID
            // 
            this.cID.Text = "ID";
            this.cID.Width = 80;
            // 
            // cNome
            // 
            this.cNome.Text = "Nome";
            this.cNome.Width = 150;
            // 
            // cPreco
            // 
            this.cPreco.Text = "Preço";
            this.cPreco.Width = 100;
            // 
            // cMarca
            // 
            this.cMarca.Text = "Marca";
            this.cMarca.Width = 150;
            // 
            // cCategoria
            // 
            this.cCategoria.Text = "Categoria";
            this.cCategoria.Width = 150;
            // 
            // estadoProd
            // 
            this.estadoProd.Text = "Estado";
            this.estadoProd.Width = 80;
            // 
            // precoCompra
            // 
            this.precoCompra.Text = "Preço de compra";
            this.precoCompra.Width = 150;
            // 
            // comboBox_categoria
            // 
            this.comboBox_categoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_categoria.FormattingEnabled = true;
            this.comboBox_categoria.Location = new System.Drawing.Point(498, 84);
            this.comboBox_categoria.Name = "comboBox_categoria";
            this.comboBox_categoria.Size = new System.Drawing.Size(146, 27);
            this.comboBox_categoria.TabIndex = 13;
            this.comboBox_categoria.SelectedIndexChanged += new System.EventHandler(this.comboBox_fornecedor_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(386, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Categoria:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // comboBox_marca
            // 
            this.comboBox_marca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_marca.FormattingEnabled = true;
            this.comboBox_marca.Location = new System.Drawing.Point(84, 84);
            this.comboBox_marca.Name = "comboBox_marca";
            this.comboBox_marca.Size = new System.Drawing.Size(287, 27);
            this.comboBox_marca.TabIndex = 15;
            // 
            // button_cadprod
            // 
            this.button_cadprod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_cadprod.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_cadprod.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_cadprod.Location = new System.Drawing.Point(14, 501);
            this.button_cadprod.Name = "button_cadprod";
            this.button_cadprod.Size = new System.Drawing.Size(106, 46);
            this.button_cadprod.TabIndex = 16;
            this.button_cadprod.Text = "Cadastar";
            this.button_cadprod.UseVisualStyleBackColor = false;
            this.button_cadprod.Click += new System.EventHandler(this.button_cadprod_Click);
            // 
            // button_editarprod
            // 
            this.button_editarprod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_editarprod.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_editarprod.Location = new System.Drawing.Point(159, 501);
            this.button_editarprod.Name = "button_editarprod";
            this.button_editarprod.Size = new System.Drawing.Size(115, 46);
            this.button_editarprod.TabIndex = 17;
            this.button_editarprod.Text = "Editar";
            this.button_editarprod.UseVisualStyleBackColor = false;
            this.button_editarprod.Click += new System.EventHandler(this.button_editarprod_Click);
            // 
            // button_excluirpro
            // 
            this.button_excluirpro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_excluirpro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_excluirpro.Location = new System.Drawing.Point(800, 501);
            this.button_excluirpro.Name = "button_excluirpro";
            this.button_excluirpro.Size = new System.Drawing.Size(103, 46);
            this.button_excluirpro.TabIndex = 18;
            this.button_excluirpro.Text = "Desativar";
            this.button_excluirpro.UseVisualStyleBackColor = false;
            this.button_excluirpro.Click += new System.EventHandler(this.button_excluirpro_Click);
            // 
            // TextBox_precoproduto
            // 
            this.TextBox_precoproduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_precoproduto.Location = new System.Drawing.Point(731, 86);
            this.TextBox_precoproduto.Name = "TextBox_precoproduto";
            this.TextBox_precoproduto.Size = new System.Drawing.Size(172, 27);
            this.TextBox_precoproduto.TabIndex = 19;
            this.TextBox_precoproduto.TextChanged += new System.EventHandler(this.TextBox_precoproduto_TextChanged);
            // 
            // cbEstadoProd
            // 
            this.cbEstadoProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbEstadoProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoProd.FormattingEnabled = true;
            this.cbEstadoProd.Items.AddRange(new object[] {
            "Ativado",
            "Desativado"});
            this.cbEstadoProd.Location = new System.Drawing.Point(160, 119);
            this.cbEstadoProd.Name = "cbEstadoProd";
            this.cbEstadoProd.Size = new System.Drawing.Size(332, 27);
            this.cbEstadoProd.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(14, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Estado Produto:";
            // 
            // tbPrecoCompra
            // 
            this.tbPrecoCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPrecoCompra.Location = new System.Drawing.Point(650, 119);
            this.tbPrecoCompra.Name = "tbPrecoCompra";
            this.tbPrecoCompra.Size = new System.Drawing.Size(253, 27);
            this.tbPrecoCompra.TabIndex = 28;
            this.tbPrecoCompra.TextChanged += new System.EventHandler(this.tbPrecoCompra_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(498, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Preço de compra:";
            // 
            // checkB_estado
            // 
            this.checkB_estado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkB_estado.AutoSize = true;
            this.checkB_estado.BackColor = System.Drawing.Color.Transparent;
            this.checkB_estado.Location = new System.Drawing.Point(524, 522);
            this.checkB_estado.Name = "checkB_estado";
            this.checkB_estado.Size = new System.Drawing.Size(270, 23);
            this.checkB_estado.TabIndex = 29;
            this.checkB_estado.Text = "Mostrar produtos desativados";
            this.checkB_estado.UseVisualStyleBackColor = false;
            this.checkB_estado.CheckedChanged += new System.EventHandler(this.checkB_estado_CheckedChanged);
            // 
            // GerirProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 557);
            this.Controls.Add(this.checkB_estado);
            this.Controls.Add(this.tbPrecoCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEstadoProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox_precoproduto);
            this.Controls.Add(this.button_excluirpro);
            this.Controls.Add(this.button_editarprod);
            this.Controls.Add(this.button_cadprod);
            this.Controls.Add(this.comboBox_marca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_categoria);
            this.Controls.Add(this.listView_produto);
            this.Controls.Add(this.textBox_nomeproduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerirProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerir Produto";
            this.Load += new System.EventHandler(this.GerirProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_nomeproduto;
        private System.Windows.Forms.ListView listView_produto;
        private System.Windows.Forms.ComboBox comboBox_categoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_marca;
        private System.Windows.Forms.Button button_cadprod;
        private System.Windows.Forms.Button button_editarprod;
        private System.Windows.Forms.Button button_excluirpro;
        private System.Windows.Forms.TextBox TextBox_precoproduto;
        private System.Windows.Forms.ColumnHeader cID;
        private System.Windows.Forms.ColumnHeader cNome;
        private System.Windows.Forms.ColumnHeader cMarca;
        private System.Windows.Forms.ColumnHeader cCategoria;
        private System.Windows.Forms.ColumnHeader cPreco;
        private System.Windows.Forms.ComboBox cbEstadoProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrecoCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader estadoProd;
        private System.Windows.Forms.ColumnHeader precoCompra;
        private System.Windows.Forms.CheckBox checkB_estado;
    }
}