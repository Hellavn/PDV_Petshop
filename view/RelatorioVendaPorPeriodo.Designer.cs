
namespace Projeto_Petshop.view
{
    partial class RelatorioVendaPorPeriodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioVendaPorPeriodo));
            this.lv_relatorio = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.total_venda = new System.Windows.Forms.ColumnHeader();
            this.formapagamento = new System.Windows.Forms.ColumnHeader();
            this.data = new System.Windows.Forms.ColumnHeader();
            this.nomeusuario = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_pdf = new System.Windows.Forms.Button();
            this.bt_gerar = new System.Windows.Forms.Button();
            this.cal_datainicial = new System.Windows.Forms.MonthCalendar();
            this.cal_datafinal = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // lv_relatorio
            // 
            this.lv_relatorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lv_relatorio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.total_venda,
            this.formapagamento,
            this.data,
            this.nomeusuario});
            this.lv_relatorio.HideSelection = false;
            this.lv_relatorio.Location = new System.Drawing.Point(12, 181);
            this.lv_relatorio.Name = "lv_relatorio";
            this.lv_relatorio.Size = new System.Drawing.Size(775, 411);
            this.lv_relatorio.TabIndex = 14;
            this.lv_relatorio.UseCompatibleStateImageBehavior = false;
            this.lv_relatorio.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 80;
            // 
            // total_venda
            // 
            this.total_venda.Text = "Valor total";
            this.total_venda.Width = 200;
            // 
            // formapagamento
            // 
            this.formapagamento.Text = "Forma de Pagamento";
            this.formapagamento.Width = 150;
            // 
            // data
            // 
            this.data.Text = "Data da Venda";
            this.data.Width = 150;
            // 
            // nomeusuario
            // 
            this.nomeusuario.Text = "Nome Usuario";
            this.nomeusuario.Width = 100;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(353, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Data Final:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Data inicial:";
            // 
            // bt_pdf
            // 
            this.bt_pdf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_pdf.BackColor = System.Drawing.Color.Transparent;
            this.bt_pdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_pdf.BackgroundImage")));
            this.bt_pdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_pdf.Location = new System.Drawing.Point(733, 598);
            this.bt_pdf.Name = "bt_pdf";
            this.bt_pdf.Size = new System.Drawing.Size(54, 46);
            this.bt_pdf.TabIndex = 24;
            this.bt_pdf.UseVisualStyleBackColor = false;
            this.bt_pdf.Click += new System.EventHandler(this.bt_pdf_Click);
            // 
            // bt_gerar
            // 
            this.bt_gerar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_gerar.Location = new System.Drawing.Point(301, 598);
            this.bt_gerar.Name = "bt_gerar";
            this.bt_gerar.Size = new System.Drawing.Size(209, 46);
            this.bt_gerar.TabIndex = 23;
            this.bt_gerar.Text = "Gerar relatório";
            this.bt_gerar.UseVisualStyleBackColor = true;
            this.bt_gerar.Click += new System.EventHandler(this.bt_gerar_Click);
            // 
            // cal_datainicial
            // 
            this.cal_datainicial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cal_datainicial.Location = new System.Drawing.Point(115, 7);
            this.cal_datainicial.Name = "cal_datainicial";
            this.cal_datainicial.TabIndex = 25;
            this.cal_datainicial.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.cal_datainicial_DateSelected);
            // 
            // cal_datafinal
            // 
            this.cal_datafinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cal_datafinal.Location = new System.Drawing.Point(448, 7);
            this.cal_datafinal.Name = "cal_datafinal";
            this.cal_datafinal.TabIndex = 26;
            this.cal_datafinal.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.cal_datafinal_DateSelected);
            // 
            // RelatorioVendaPorPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(809, 656);
            this.Controls.Add(this.cal_datafinal);
            this.Controls.Add(this.cal_datainicial);
            this.Controls.Add(this.bt_pdf);
            this.Controls.Add(this.bt_gerar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lv_relatorio);
            this.Name = "RelatorioVendaPorPeriodo";
            this.Text = "Relatorio Venda Por Periodo";
            this.Load += new System.EventHandler(this.RelatorioVendaPorPeriodo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_relatorio;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader total_venda;
        private System.Windows.Forms.ColumnHeader formapagamento;
        private System.Windows.Forms.ColumnHeader data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_pdf;
        private System.Windows.Forms.Button bt_gerar;
        private System.Windows.Forms.ColumnHeader nomeusuario;
        private System.Windows.Forms.MonthCalendar cal_datainicial;
        private System.Windows.Forms.MonthCalendar cal_datafinal;
    }
}