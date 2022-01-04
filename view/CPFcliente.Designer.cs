namespace Projeto_Petshop.view
{
    partial class CPFcliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPFcliente));
            this.tb_cpfcliente = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_pesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_cpfcliente
            // 
            this.tb_cpfcliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_cpfcliente.BackColor = System.Drawing.Color.DarkGray;
            this.tb_cpfcliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_cpfcliente.Location = new System.Drawing.Point(81, 55);
            this.tb_cpfcliente.Mask = "000,000,000-00";
            this.tb_cpfcliente.Name = "tb_cpfcliente";
            this.tb_cpfcliente.Size = new System.Drawing.Size(110, 29);
            this.tb_cpfcliente.TabIndex = 0;
            this.tb_cpfcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cpfcliente_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPF:";
            // 
            // bt_pesquisar
            // 
            this.bt_pesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_pesquisar.Location = new System.Drawing.Point(93, 90);
            this.bt_pesquisar.Name = "bt_pesquisar";
            this.bt_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.bt_pesquisar.TabIndex = 2;
            this.bt_pesquisar.Text = "Pesquisar";
            this.bt_pesquisar.UseVisualStyleBackColor = true;
            this.bt_pesquisar.Click += new System.EventHandler(this.bt_pesquisar_Click);
            // 
            // CPFcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(279, 176);
            this.Controls.Add(this.bt_pesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_cpfcliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CPFcliente";
            this.Text = "Informar CPF do cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tb_cpfcliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_pesquisar;
    }
}