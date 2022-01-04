
namespace Projeto_Petshop.view
{
    partial class TelaPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.menus = new System.Windows.Forms.MenuStrip();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeVendasPorPeriodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechamentosubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.gerirProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeVencimentoDeProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeProdutosMaisVendidosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeProdutosComBaixoEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerirMarcasubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeVendasPorMarcasubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.gerirCategoriasubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeVendaPorCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerirUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerirFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerirClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoque = new System.Windows.Forms.ToolStripMenuItem();
            this.gerirEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarMargemDeLucroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_baixoestoque = new System.Windows.Forms.Button();
            this.bt_produtosvencidos = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menus.SuspendLayout();
            this.SuspendLayout();
            // 
            // menus
            // 
            this.menus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caixaToolStripMenuItem,
            this.produtosMenu,
            this.marcaToolStripMenuItem,
            this.categoriaMenu,
            this.usuáriosToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.estoque,
            this.sairToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menus.Location = new System.Drawing.Point(0, 0);
            this.menus.Name = "menus";
            this.menus.Size = new System.Drawing.Size(1001, 24);
            this.menus.TabIndex = 10;
            this.menus.Text = "menuStrip1";
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caixaToolStripMenuItem1,
            this.relatórioDeVendasPorPeriodoToolStripMenuItem,
            this.fechamentosubmenu});
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.caixaToolStripMenuItem.Text = "Vendas";
            // 
            // caixaToolStripMenuItem1
            // 
            this.caixaToolStripMenuItem1.Name = "caixaToolStripMenuItem1";
            this.caixaToolStripMenuItem1.Size = new System.Drawing.Size(242, 22);
            this.caixaToolStripMenuItem1.Text = "Caixa";
            this.caixaToolStripMenuItem1.Click += new System.EventHandler(this.caixaToolStripMenuItem1_Click);
            // 
            // relatórioDeVendasPorPeriodoToolStripMenuItem
            // 
            this.relatórioDeVendasPorPeriodoToolStripMenuItem.Name = "relatórioDeVendasPorPeriodoToolStripMenuItem";
            this.relatórioDeVendasPorPeriodoToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.relatórioDeVendasPorPeriodoToolStripMenuItem.Text = "Relatório de vendas por periodo";
            this.relatórioDeVendasPorPeriodoToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeVendasPorPeriodoToolStripMenuItem_Click);
            // 
            // fechamentosubmenu
            // 
            this.fechamentosubmenu.Name = "fechamentosubmenu";
            this.fechamentosubmenu.Size = new System.Drawing.Size(242, 22);
            this.fechamentosubmenu.Text = "Fechamento";
            this.fechamentosubmenu.Click += new System.EventHandler(this.fechamentosubmenu_Click);
            // 
            // produtosMenu
            // 
            this.produtosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerirProdutosToolStripMenuItem,
            this.relatórioDeVencimentoDeProdutoToolStripMenuItem,
            this.relatórioDeProdutosMaisVendidosToolStripMenuItem1,
            this.relatórioDeProdutosComBaixoEstoqueToolStripMenuItem});
            this.produtosMenu.Name = "produtosMenu";
            this.produtosMenu.Size = new System.Drawing.Size(67, 20);
            this.produtosMenu.Text = "Produtos";
            // 
            // gerirProdutosToolStripMenuItem
            // 
            this.gerirProdutosToolStripMenuItem.Name = "gerirProdutosToolStripMenuItem";
            this.gerirProdutosToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.gerirProdutosToolStripMenuItem.Text = "Gerir produtos";
            this.gerirProdutosToolStripMenuItem.Click += new System.EventHandler(this.gerirProdutosToolStripMenuItem_Click);
            // 
            // relatórioDeVencimentoDeProdutoToolStripMenuItem
            // 
            this.relatórioDeVencimentoDeProdutoToolStripMenuItem.Name = "relatórioDeVencimentoDeProdutoToolStripMenuItem";
            this.relatórioDeVencimentoDeProdutoToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.relatórioDeVencimentoDeProdutoToolStripMenuItem.Text = "Relatório de vencimento de produto";
            this.relatórioDeVencimentoDeProdutoToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeVencimentoDeProdutoToolStripMenuItem_Click);
            // 
            // relatórioDeProdutosMaisVendidosToolStripMenuItem1
            // 
            this.relatórioDeProdutosMaisVendidosToolStripMenuItem1.Name = "relatórioDeProdutosMaisVendidosToolStripMenuItem1";
            this.relatórioDeProdutosMaisVendidosToolStripMenuItem1.Size = new System.Drawing.Size(292, 22);
            this.relatórioDeProdutosMaisVendidosToolStripMenuItem1.Text = "Relatório de produtos mais vendidos";
            this.relatórioDeProdutosMaisVendidosToolStripMenuItem1.Click += new System.EventHandler(this.relatórioDeProdutosMaisVendidosToolStripMenuItem1_Click);
            // 
            // relatórioDeProdutosComBaixoEstoqueToolStripMenuItem
            // 
            this.relatórioDeProdutosComBaixoEstoqueToolStripMenuItem.Name = "relatórioDeProdutosComBaixoEstoqueToolStripMenuItem";
            this.relatórioDeProdutosComBaixoEstoqueToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.relatórioDeProdutosComBaixoEstoqueToolStripMenuItem.Text = "Relatório de produtos com baixo estoque";
            this.relatórioDeProdutosComBaixoEstoqueToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeProdutosComBaixoEstoqueToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerirMarcasubmenu,
            this.relatórioDeVendasPorMarcasubMenu});
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.marcaToolStripMenuItem.Text = "Marca";
            // 
            // gerirMarcasubmenu
            // 
            this.gerirMarcasubmenu.Name = "gerirMarcasubmenu";
            this.gerirMarcasubmenu.Size = new System.Drawing.Size(234, 22);
            this.gerirMarcasubmenu.Text = "Gerir Marca";
            this.gerirMarcasubmenu.Click += new System.EventHandler(this.gerirMarcasubmenu_Click);
            // 
            // relatórioDeVendasPorMarcasubMenu
            // 
            this.relatórioDeVendasPorMarcasubMenu.Name = "relatórioDeVendasPorMarcasubMenu";
            this.relatórioDeVendasPorMarcasubMenu.Size = new System.Drawing.Size(234, 22);
            this.relatórioDeVendasPorMarcasubMenu.Text = "Relatório de vendas por marca";
            this.relatórioDeVendasPorMarcasubMenu.Click += new System.EventHandler(this.relatórioDeVendasPorMarcasubMenu_Click);
            // 
            // categoriaMenu
            // 
            this.categoriaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerirCategoriasubmenu,
            this.relatórioDeVendaPorCategoriaToolStripMenuItem});
            this.categoriaMenu.Name = "categoriaMenu";
            this.categoriaMenu.Size = new System.Drawing.Size(70, 20);
            this.categoriaMenu.Text = "Categoria";
            // 
            // gerirCategoriasubmenu
            // 
            this.gerirCategoriasubmenu.Name = "gerirCategoriasubmenu";
            this.gerirCategoriasubmenu.Size = new System.Drawing.Size(245, 22);
            this.gerirCategoriasubmenu.Text = "Gerir Categoria";
            this.gerirCategoriasubmenu.Click += new System.EventHandler(this.gerirCategoriasubmenu_Click);
            // 
            // relatórioDeVendaPorCategoriaToolStripMenuItem
            // 
            this.relatórioDeVendaPorCategoriaToolStripMenuItem.Name = "relatórioDeVendaPorCategoriaToolStripMenuItem";
            this.relatórioDeVendaPorCategoriaToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.relatórioDeVendaPorCategoriaToolStripMenuItem.Text = "Relatório de venda por categoria";
            this.relatórioDeVendaPorCategoriaToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeVendaPorCategoriaToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerirUsuáriosToolStripMenuItem});
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // gerirUsuáriosToolStripMenuItem
            // 
            this.gerirUsuáriosToolStripMenuItem.Name = "gerirUsuáriosToolStripMenuItem";
            this.gerirUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.gerirUsuáriosToolStripMenuItem.Text = "Gerir Usuários";
            this.gerirUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.gerirUsuáriosToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerirFornecedoresToolStripMenuItem});
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // gerirFornecedoresToolStripMenuItem
            // 
            this.gerirFornecedoresToolStripMenuItem.Name = "gerirFornecedoresToolStripMenuItem";
            this.gerirFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.gerirFornecedoresToolStripMenuItem.Text = "Gerir Fornecedores";
            this.gerirFornecedoresToolStripMenuItem.Click += new System.EventHandler(this.gerirFornecedoresToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerirClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.clientesToolStripMenuItem.Text = "Clientes ";
            // 
            // gerirClientesToolStripMenuItem
            // 
            this.gerirClientesToolStripMenuItem.Name = "gerirClientesToolStripMenuItem";
            this.gerirClientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gerirClientesToolStripMenuItem.Text = "Gerir Clientes";
            this.gerirClientesToolStripMenuItem.Click += new System.EventHandler(this.gerirClientesToolStripMenuItem_Click);
            // 
            // estoque
            // 
            this.estoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerirEstoqueToolStripMenuItem,
            this.configurarMargemDeLucroToolStripMenuItem});
            this.estoque.Name = "estoque";
            this.estoque.Size = new System.Drawing.Size(61, 20);
            this.estoque.Text = "Estoque";
            // 
            // gerirEstoqueToolStripMenuItem
            // 
            this.gerirEstoqueToolStripMenuItem.Name = "gerirEstoqueToolStripMenuItem";
            this.gerirEstoqueToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.gerirEstoqueToolStripMenuItem.Text = "Gerir Estoque";
            this.gerirEstoqueToolStripMenuItem.Click += new System.EventHandler(this.gerirEstoqueToolStripMenuItem_Click);
            // 
            // configurarMargemDeLucroToolStripMenuItem
            // 
            this.configurarMargemDeLucroToolStripMenuItem.Name = "configurarMargemDeLucroToolStripMenuItem";
            this.configurarMargemDeLucroToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.configurarMargemDeLucroToolStripMenuItem.Text = "Configurar Margem de Lucro";
            this.configurarMargemDeLucroToolStripMenuItem.Click += new System.EventHandler(this.configurarMargemDeLucroToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // bt_baixoestoque
            // 
            this.bt_baixoestoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_baixoestoque.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_baixoestoque.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_baixoestoque.FlatAppearance.BorderSize = 0;
            this.bt_baixoestoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_baixoestoque.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_baixoestoque.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_baixoestoque.Location = new System.Drawing.Point(542, 476);
            this.bt_baixoestoque.Name = "bt_baixoestoque";
            this.bt_baixoestoque.Size = new System.Drawing.Size(156, 47);
            this.bt_baixoestoque.TabIndex = 12;
            this.bt_baixoestoque.Text = "Baixo estoque";
            this.bt_baixoestoque.UseVisualStyleBackColor = false;
            this.bt_baixoestoque.Click += new System.EventHandler(this.bt_baixoestoque_Click);
            // 
            // bt_produtosvencidos
            // 
            this.bt_produtosvencidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_produtosvencidos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_produtosvencidos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_produtosvencidos.FlatAppearance.BorderSize = 0;
            this.bt_produtosvencidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_produtosvencidos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_produtosvencidos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_produtosvencidos.Location = new System.Drawing.Point(201, 476);
            this.bt_produtosvencidos.Name = "bt_produtosvencidos";
            this.bt_produtosvencidos.Size = new System.Drawing.Size(156, 47);
            this.bt_produtosvencidos.TabIndex = 13;
            this.bt_produtosvencidos.Text = "Produtos vencidos";
            this.bt_produtosvencidos.UseVisualStyleBackColor = false;
            this.bt_produtosvencidos.Click += new System.EventHandler(this.bt_produtosvencidos_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1001, 602);
            this.Controls.Add(this.bt_produtosvencidos);
            this.Controls.Add(this.bt_baixoestoque);
            this.Controls.Add(this.menus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPrincipal";
            this.Text = "Tela Principal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.menus.ResumeLayout(false);
            this.menus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip Produtos;
        private System.Windows.Forms.MenuStrip menus;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtosMenu;
        private System.Windows.Forms.ToolStripMenuItem gerirProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeVencimentoDeProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeProdutosMaisVendidosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeVendasPorPeriodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeProdutosComBaixoEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerirMarcasubmenu;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeVendasPorMarcasubMenu;
        private System.Windows.Forms.ToolStripMenuItem categoriaMenu;
        private System.Windows.Forms.ToolStripMenuItem gerirCategoriasubmenu;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerirUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerirFornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerirClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoque;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerirEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarMargemDeLucroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeVendaPorCategoriaToolStripMenuItem;
        private System.Windows.Forms.Button bt_baixoestoque;
        private System.Windows.Forms.Button bt_produtosvencidos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechamentosubmenu;
        private System.Windows.Forms.Timer timer2;
    }
}