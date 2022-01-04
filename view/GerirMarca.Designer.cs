
namespace Projeto_Petshop.view
{
    partial class GerirMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirMarca));
            this.lbnome = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.lv_marca = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.nome = new System.Windows.Forms.ColumnHeader();
            this.estado = new System.Windows.Forms.ColumnHeader();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_dstv = new System.Windows.Forms.Button();
            this.cb_inativos = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbnome
            // 
            this.lbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbnome.AutoSize = true;
            this.lbnome.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbnome.Location = new System.Drawing.Point(12, 9);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(66, 23);
            this.lbnome.TabIndex = 0;
            this.lbnome.Text = "Nome:";
            this.lbnome.Click += new System.EventHandler(this.lbnome_Click);
            // 
            // tb_nome
            // 
            this.tb_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_nome.Location = new System.Drawing.Point(85, 8);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(340, 23);
            this.tb_nome.TabIndex = 1;
            this.tb_nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lv_marca
            // 
            this.lv_marca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lv_marca.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nome,
            this.estado});
            this.lv_marca.HideSelection = false;
            this.lv_marca.Location = new System.Drawing.Point(13, 36);
            this.lv_marca.Name = "lv_marca";
            this.lv_marca.Size = new System.Drawing.Size(412, 215);
            this.lv_marca.TabIndex = 2;
            this.lv_marca.UseCompatibleStateImageBehavior = false;
            this.lv_marca.View = System.Windows.Forms.View.Details;
            this.lv_marca.SelectedIndexChanged += new System.EventHandler(this.lv_marca_SelectedIndexChanged);
            this.lv_marca.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_marca_MouseClick);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 30;
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 150;
            // 
            // estado
            // 
            this.estado.Text = "Estado";
            this.estado.Width = 100;
            // 
            // bt_add
            // 
            this.bt_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_add.Location = new System.Drawing.Point(13, 254);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 3;
            this.bt_add.Text = "Adicionar";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_editar.Location = new System.Drawing.Point(95, 253);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(75, 23);
            this.bt_editar.TabIndex = 4;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = true;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // bt_dstv
            // 
            this.bt_dstv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_dstv.Location = new System.Drawing.Point(176, 254);
            this.bt_dstv.Name = "bt_dstv";
            this.bt_dstv.Size = new System.Drawing.Size(132, 23);
            this.bt_dstv.TabIndex = 5;
            this.bt_dstv.Text = "Mudar estado";
            this.bt_dstv.UseVisualStyleBackColor = true;
            this.bt_dstv.Click += new System.EventHandler(this.bt_dstv_Click);
            // 
            // cb_inativos
            // 
            this.cb_inativos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_inativos.AutoSize = true;
            this.cb_inativos.Location = new System.Drawing.Point(314, 258);
            this.cb_inativos.Name = "cb_inativos";
            this.cb_inativos.Size = new System.Drawing.Size(111, 19);
            this.cb_inativos.TabIndex = 6;
            this.cb_inativos.Text = "Mostrar inativos";
            this.cb_inativos.UseVisualStyleBackColor = true;
            this.cb_inativos.CheckedChanged += new System.EventHandler(this.cb_inativos_CheckedChanged);
            // 
            // GerirMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(437, 289);
            this.Controls.Add(this.cb_inativos);
            this.Controls.Add(this.bt_dstv);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.lv_marca);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lbnome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerirMarca";
            this.Text = "Gerir Marca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.ListView lv_marca;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_dstv;
        private System.Windows.Forms.CheckBox cb_inativos;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader estado;
    }
}