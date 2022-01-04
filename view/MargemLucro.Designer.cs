
namespace Projeto_Petshop.view
{
    partial class MargemLucro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MargemLucro));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_margemdelucro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_promo = new System.Windows.Forms.Button();
            this.tb_codprod = new System.Windows.Forms.TextBox();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Margem de lucro:";
            // 
            // tb_margemdelucro
            // 
            this.tb_margemdelucro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_margemdelucro.BackColor = System.Drawing.SystemColors.Info;
            this.tb_margemdelucro.Location = new System.Drawing.Point(120, 43);
            this.tb_margemdelucro.Name = "tb_margemdelucro";
            this.tb_margemdelucro.Size = new System.Drawing.Size(46, 23);
            this.tb_margemdelucro.TabIndex = 6;
            this.tb_margemdelucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_margemdelucro_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(172, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "%";
            // 
            // bt_promo
            // 
            this.bt_promo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_promo.Location = new System.Drawing.Point(57, 84);
            this.bt_promo.Name = "bt_promo";
            this.bt_promo.Size = new System.Drawing.Size(109, 23);
            this.bt_promo.TabIndex = 10;
            this.bt_promo.Text = "Definir margem";
            this.bt_promo.UseVisualStyleBackColor = true;
            this.bt_promo.Click += new System.EventHandler(this.bt_promo_Click);
            // 
            // tb_codprod
            // 
            this.tb_codprod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_codprod.BackColor = System.Drawing.SystemColors.Info;
            this.tb_codprod.Location = new System.Drawing.Point(68, 6);
            this.tb_codprod.Name = "tb_codprod";
            this.tb_codprod.Size = new System.Drawing.Size(99, 23);
            this.tb_codprod.TabIndex = 11;
            this.tb_codprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_codprod_KeyPress);
            // 
            // bt_buscar
            // 
            this.bt_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_buscar.Location = new System.Drawing.Point(173, 5);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(71, 23);
            this.bt_buscar.TabIndex = 12;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // MargemLucro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(256, 119);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.tb_codprod);
            this.Controls.Add(this.bt_promo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_margemdelucro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MargemLucro";
            this.Text = "MargemLucro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_margemdelucro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_promo;
        private System.Windows.Forms.TextBox tb_codprod;
        private System.Windows.Forms.Button bt_buscar;
    }
}