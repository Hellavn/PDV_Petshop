
namespace Projeto_Petshop.view
{
    partial class GerirUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Nomeusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_funcao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_enderecoUsuario = new System.Windows.Forms.TextBox();
            this.textBox_emailUsuario = new System.Windows.Forms.TextBox();
            this.textBox_senhaUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_cadastrarUsuario = new System.Windows.Forms.Button();
            this.button_editarUsuario = new System.Windows.Forms.Button();
            this.button_excluirUsuario = new System.Windows.Forms.Button();
            this.listView_usuario = new System.Windows.Forms.ListView();
            this.col_ID = new System.Windows.Forms.ColumnHeader();
            this.col_nome = new System.Windows.Forms.ColumnHeader();
            this.col_cpf = new System.Windows.Forms.ColumnHeader();
            this.col_senha = new System.Windows.Forms.ColumnHeader();
            this.col_endereco = new System.Windows.Forms.ColumnHeader();
            this.col_telefone = new System.Windows.Forms.ColumnHeader();
            this.col_funcao = new System.Windows.Forms.ColumnHeader();
            this.col_email = new System.Windows.Forms.ColumnHeader();
            this.textBox_telUsuario = new System.Windows.Forms.MaskedTextBox();
            this.textBox_cpfUsuario = new System.Windows.Forms.MaskedTextBox();
            this.tb_repSenha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // textBox_Nomeusuario
            // 
            this.textBox_Nomeusuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Nomeusuario.Location = new System.Drawing.Point(90, 70);
            this.textBox_Nomeusuario.Name = "textBox_Nomeusuario";
            this.textBox_Nomeusuario.Size = new System.Drawing.Size(384, 23);
            this.textBox_Nomeusuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(480, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail:";
            // 
            // comboBox_funcao
            // 
            this.comboBox_funcao.AllowDrop = true;
            this.comboBox_funcao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_funcao.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox_funcao.DisplayMember = "none";
            this.comboBox_funcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_funcao.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_funcao.FormattingEnabled = true;
            this.comboBox_funcao.Items.AddRange(new object[] {
            "Gerente",
            "Caixa",
            "Vendedor"});
            this.comboBox_funcao.Location = new System.Drawing.Point(564, 102);
            this.comboBox_funcao.Name = "comboBox_funcao";
            this.comboBox_funcao.Size = new System.Drawing.Size(135, 27);
            this.comboBox_funcao.TabIndex = 5;
            this.comboBox_funcao.ValueMember = "none";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(480, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Função:";
            // 
            // textBox_enderecoUsuario
            // 
            this.textBox_enderecoUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_enderecoUsuario.Location = new System.Drawing.Point(115, 105);
            this.textBox_enderecoUsuario.Name = "textBox_enderecoUsuario";
            this.textBox_enderecoUsuario.Size = new System.Drawing.Size(359, 23);
            this.textBox_enderecoUsuario.TabIndex = 7;
            // 
            // textBox_emailUsuario
            // 
            this.textBox_emailUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_emailUsuario.Location = new System.Drawing.Point(105, 144);
            this.textBox_emailUsuario.Name = "textBox_emailUsuario";
            this.textBox_emailUsuario.Size = new System.Drawing.Size(218, 23);
            this.textBox_emailUsuario.TabIndex = 8;
            // 
            // textBox_senhaUsuario
            // 
            this.textBox_senhaUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_senhaUsuario.Location = new System.Drawing.Point(319, 173);
            this.textBox_senhaUsuario.Name = "textBox_senhaUsuario";
            this.textBox_senhaUsuario.PasswordChar = '*';
            this.textBox_senhaUsuario.Size = new System.Drawing.Size(151, 23);
            this.textBox_senhaUsuario.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "CPF:";
            // 
            // button_cadastrarUsuario
            // 
            this.button_cadastrarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_cadastrarUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_cadastrarUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_cadastrarUsuario.Location = new System.Drawing.Point(135, 477);
            this.button_cadastrarUsuario.Name = "button_cadastrarUsuario";
            this.button_cadastrarUsuario.Size = new System.Drawing.Size(102, 30);
            this.button_cadastrarUsuario.TabIndex = 14;
            this.button_cadastrarUsuario.Text = "Cadastrar";
            this.button_cadastrarUsuario.UseVisualStyleBackColor = false;
            this.button_cadastrarUsuario.Click += new System.EventHandler(this.button_cadastrarUsuario_Click);
            // 
            // button_editarUsuario
            // 
            this.button_editarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_editarUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_editarUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_editarUsuario.Location = new System.Drawing.Point(290, 477);
            this.button_editarUsuario.Name = "button_editarUsuario";
            this.button_editarUsuario.Size = new System.Drawing.Size(102, 30);
            this.button_editarUsuario.TabIndex = 15;
            this.button_editarUsuario.Text = "Editar";
            this.button_editarUsuario.UseVisualStyleBackColor = false;
            this.button_editarUsuario.Click += new System.EventHandler(this.button_editarUsuario_Click);
            // 
            // button_excluirUsuario
            // 
            this.button_excluirUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_excluirUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_excluirUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_excluirUsuario.Location = new System.Drawing.Point(447, 477);
            this.button_excluirUsuario.Name = "button_excluirUsuario";
            this.button_excluirUsuario.Size = new System.Drawing.Size(102, 30);
            this.button_excluirUsuario.TabIndex = 16;
            this.button_excluirUsuario.Text = "Excluir";
            this.button_excluirUsuario.UseVisualStyleBackColor = false;
            this.button_excluirUsuario.Click += new System.EventHandler(this.button_excluirUsuario_Click);
            // 
            // listView_usuario
            // 
            this.listView_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView_usuario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_ID,
            this.col_nome,
            this.col_cpf,
            this.col_senha,
            this.col_endereco,
            this.col_telefone,
            this.col_funcao,
            this.col_email});
            this.listView_usuario.HideSelection = false;
            this.listView_usuario.Location = new System.Drawing.Point(15, 216);
            this.listView_usuario.Name = "listView_usuario";
            this.listView_usuario.Size = new System.Drawing.Size(765, 255);
            this.listView_usuario.TabIndex = 18;
            this.listView_usuario.UseCompatibleStateImageBehavior = false;
            this.listView_usuario.View = System.Windows.Forms.View.Details;
            this.listView_usuario.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // col_ID
            // 
            this.col_ID.Text = "Id";
            this.col_ID.Width = 40;
            // 
            // col_nome
            // 
            this.col_nome.Text = "Nome";
            this.col_nome.Width = 150;
            // 
            // col_cpf
            // 
            this.col_cpf.Text = "CPF";
            this.col_cpf.Width = 80;
            // 
            // col_senha
            // 
            this.col_senha.Text = "Senha";
            this.col_senha.Width = 0;
            // 
            // col_endereco
            // 
            this.col_endereco.Text = "Endereço";
            this.col_endereco.Width = 150;
            // 
            // col_telefone
            // 
            this.col_telefone.Text = "Telefone";
            this.col_telefone.Width = 80;
            // 
            // col_funcao
            // 
            this.col_funcao.Text = "Função";
            this.col_funcao.Width = 80;
            // 
            // col_email
            // 
            this.col_email.Text = "E-mail";
            this.col_email.Width = 100;
            // 
            // textBox_telUsuario
            // 
            this.textBox_telUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_telUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_telUsuario.Location = new System.Drawing.Point(564, 70);
            this.textBox_telUsuario.Mask = "(00)00000-0000";
            this.textBox_telUsuario.Name = "textBox_telUsuario";
            this.textBox_telUsuario.Size = new System.Drawing.Size(135, 27);
            this.textBox_telUsuario.TabIndex = 19;
            this.textBox_telUsuario.TabStop = false;
            // 
            // textBox_cpfUsuario
            // 
            this.textBox_cpfUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_cpfUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_cpfUsuario.Location = new System.Drawing.Point(66, 171);
            this.textBox_cpfUsuario.Mask = "000,000,000-00";
            this.textBox_cpfUsuario.Name = "textBox_cpfUsuario";
            this.textBox_cpfUsuario.Size = new System.Drawing.Size(171, 27);
            this.textBox_cpfUsuario.TabIndex = 20;
            // 
            // tb_repSenha
            // 
            this.tb_repSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_repSenha.Location = new System.Drawing.Point(610, 173);
            this.tb_repSenha.Name = "tb_repSenha";
            this.tb_repSenha.PasswordChar = '*';
            this.tb_repSenha.Size = new System.Drawing.Size(179, 23);
            this.tb_repSenha.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(243, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Senha:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(476, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "repetir senha:";
            // 
            // GerirUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 519);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_repSenha);
            this.Controls.Add(this.textBox_cpfUsuario);
            this.Controls.Add(this.textBox_telUsuario);
            this.Controls.Add(this.listView_usuario);
            this.Controls.Add(this.button_excluirUsuario);
            this.Controls.Add(this.button_editarUsuario);
            this.Controls.Add(this.button_cadastrarUsuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_senhaUsuario);
            this.Controls.Add(this.textBox_emailUsuario);
            this.Controls.Add(this.textBox_enderecoUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_funcao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Nomeusuario);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerirUsuario";
            this.Text = "Cadastro Usuario";
            this.Load += new System.EventHandler(this.GerirUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Nomeusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_enderecoUsuario;
        private System.Windows.Forms.TextBox textBox_emailUsuario;
        private System.Windows.Forms.TextBox textBox_senhaUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_cadastrarUsuario;
        private System.Windows.Forms.Button button_editarUsuario;
        private System.Windows.Forms.Button button_excluirUsuario;
        private System.Windows.Forms.ListView listView_usuario;
        private System.Windows.Forms.ColumnHeader col_ID;
        private System.Windows.Forms.ColumnHeader col_nome;
        private System.Windows.Forms.ColumnHeader col_cpf;
        private System.Windows.Forms.ColumnHeader col_senha;
        private System.Windows.Forms.ColumnHeader col_endereco;
        private System.Windows.Forms.ColumnHeader col_telefone;
        private System.Windows.Forms.ColumnHeader col_funcao;
        private System.Windows.Forms.ColumnHeader col_email;
        private System.Windows.Forms.MaskedTextBox textBox_telUsuario;
        private System.Windows.Forms.MaskedTextBox textBox_cpfUsuario;
        public System.Windows.Forms.ComboBox comboBox_funcao;
        private System.Windows.Forms.TextBox tb_repSenha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}