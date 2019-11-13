namespace EZAsk
{
    partial class FrmSegUsuario
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
            this.tbcSeguranca = new System.Windows.Forms.TabControl();
            this.tabRedefinirSenha = new System.Windows.Forms.TabPage();
            this.CBMostrarSenha = new System.Windows.Forms.CheckBox();
            this.btnConferirSenha = new System.Windows.Forms.Button();
            this.btnCancelAlterSenha = new System.Windows.Forms.Button();
            this.btnAlterarSenha = new System.Windows.Forms.Button();
            this.txtNovaSenha2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNovaSenha1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabRedefinirEmail = new System.Windows.Forms.TabPage();
            this.btnCancelAlterEmail = new System.Windows.Forms.Button();
            this.btnAlterarEmail = new System.Windows.Forms.Button();
            this.txtSenhaUsuario_tabAlterEmail = new System.Windows.Forms.TextBox();
            this.txtNovoEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailAtual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabRedefinirNomeUsuario = new System.Windows.Forms.TabPage();
            this.btnCancelAlterLogin = new System.Windows.Forms.Button();
            this.btnAlterarNomeLogin = new System.Windows.Forms.Button();
            this.txtSenhaUsuario_tabAlterLogin = new System.Windows.Forms.TextBox();
            this.txtNovoNomeLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeLoginAtual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbcSeguranca.SuspendLayout();
            this.tabRedefinirSenha.SuspendLayout();
            this.tabRedefinirEmail.SuspendLayout();
            this.tabRedefinirNomeUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcSeguranca
            // 
            this.tbcSeguranca.Controls.Add(this.tabRedefinirSenha);
            this.tbcSeguranca.Controls.Add(this.tabRedefinirEmail);
            this.tbcSeguranca.Controls.Add(this.tabRedefinirNomeUsuario);
            this.tbcSeguranca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcSeguranca.Location = new System.Drawing.Point(0, 0);
            this.tbcSeguranca.Name = "tbcSeguranca";
            this.tbcSeguranca.SelectedIndex = 0;
            this.tbcSeguranca.Size = new System.Drawing.Size(832, 494);
            this.tbcSeguranca.TabIndex = 0;
            this.tbcSeguranca.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbcSeguranca_Selecting);
            // 
            // tabRedefinirSenha
            // 
            this.tabRedefinirSenha.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabRedefinirSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabRedefinirSenha.Controls.Add(this.CBMostrarSenha);
            this.tabRedefinirSenha.Controls.Add(this.btnConferirSenha);
            this.tabRedefinirSenha.Controls.Add(this.btnCancelAlterSenha);
            this.tabRedefinirSenha.Controls.Add(this.btnAlterarSenha);
            this.tabRedefinirSenha.Controls.Add(this.txtNovaSenha2);
            this.tabRedefinirSenha.Controls.Add(this.label8);
            this.tabRedefinirSenha.Controls.Add(this.txtNovaSenha1);
            this.tabRedefinirSenha.Controls.Add(this.label7);
            this.tabRedefinirSenha.Controls.Add(this.txtSenhaAtual);
            this.tabRedefinirSenha.Controls.Add(this.label4);
            this.tabRedefinirSenha.Location = new System.Drawing.Point(4, 22);
            this.tabRedefinirSenha.Name = "tabRedefinirSenha";
            this.tabRedefinirSenha.Padding = new System.Windows.Forms.Padding(3);
            this.tabRedefinirSenha.Size = new System.Drawing.Size(824, 468);
            this.tabRedefinirSenha.TabIndex = 0;
            this.tabRedefinirSenha.Text = "Redefinir Senha";
            // 
            // CBMostrarSenha
            // 
            this.CBMostrarSenha.AutoSize = true;
            this.CBMostrarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBMostrarSenha.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMostrarSenha.Location = new System.Drawing.Point(7, 227);
            this.CBMostrarSenha.Name = "CBMostrarSenha";
            this.CBMostrarSenha.Size = new System.Drawing.Size(118, 18);
            this.CBMostrarSenha.TabIndex = 5;
            this.CBMostrarSenha.Text = "Mostrar Senha";
            this.CBMostrarSenha.UseVisualStyleBackColor = true;
            this.CBMostrarSenha.CheckedChanged += new System.EventHandler(this.CBMostrarSenha_CheckedChanged);
            // 
            // btnConferirSenha
            // 
            this.btnConferirSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConferirSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConferirSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnConferirSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConferirSenha.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConferirSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConferirSenha.Location = new System.Drawing.Point(391, 41);
            this.btnConferirSenha.Name = "btnConferirSenha";
            this.btnConferirSenha.Size = new System.Drawing.Size(57, 26);
            this.btnConferirSenha.TabIndex = 2;
            this.btnConferirSenha.Text = "ok";
            this.btnConferirSenha.UseVisualStyleBackColor = false;
            this.btnConferirSenha.Click += new System.EventHandler(this.btnConferirSenha_Click);
            // 
            // btnCancelAlterSenha
            // 
            this.btnCancelAlterSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelAlterSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelAlterSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancelAlterSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAlterSenha.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAlterSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelAlterSenha.Location = new System.Drawing.Point(137, 267);
            this.btnCancelAlterSenha.Name = "btnCancelAlterSenha";
            this.btnCancelAlterSenha.Size = new System.Drawing.Size(118, 32);
            this.btnCancelAlterSenha.TabIndex = 7;
            this.btnCancelAlterSenha.Text = "Cancelar";
            this.btnCancelAlterSenha.UseVisualStyleBackColor = false;
            this.btnCancelAlterSenha.Click += new System.EventHandler(this.btnCancelAlterSenha_Click);
            // 
            // btnAlterarSenha
            // 
            this.btnAlterarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAlterarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAlterarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarSenha.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAlterarSenha.Location = new System.Drawing.Point(7, 267);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(118, 32);
            this.btnAlterarSenha.TabIndex = 6;
            this.btnAlterarSenha.Text = "Salvar";
            this.btnAlterarSenha.UseVisualStyleBackColor = false;
            this.btnAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_Click);
            // 
            // txtNovaSenha2
            // 
            this.txtNovaSenha2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSenha2.Location = new System.Drawing.Point(7, 176);
            this.txtNovaSenha2.Name = "txtNovaSenha2";
            this.txtNovaSenha2.PasswordChar = '●';
            this.txtNovaSenha2.Size = new System.Drawing.Size(378, 26);
            this.txtNovaSenha2.TabIndex = 4;
            this.txtNovaSenha2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNovaSenha2_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Digite novamente a senha:";
            // 
            // txtNovaSenha1
            // 
            this.txtNovaSenha1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSenha1.Location = new System.Drawing.Point(7, 108);
            this.txtNovaSenha1.Name = "txtNovaSenha1";
            this.txtNovaSenha1.PasswordChar = '●';
            this.txtNovaSenha1.Size = new System.Drawing.Size(378, 26);
            this.txtNovaSenha1.TabIndex = 3;
            this.txtNovaSenha1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNovaSenha1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nova senha:";
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaAtual.Location = new System.Drawing.Point(7, 41);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.PasswordChar = '●';
            this.txtSenhaAtual.Size = new System.Drawing.Size(378, 26);
            this.txtSenhaAtual.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Digite a senha antiga:";
            // 
            // tabRedefinirEmail
            // 
            this.tabRedefinirEmail.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabRedefinirEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabRedefinirEmail.Controls.Add(this.btnCancelAlterEmail);
            this.tabRedefinirEmail.Controls.Add(this.btnAlterarEmail);
            this.tabRedefinirEmail.Controls.Add(this.txtSenhaUsuario_tabAlterEmail);
            this.tabRedefinirEmail.Controls.Add(this.txtNovoEmail);
            this.tabRedefinirEmail.Controls.Add(this.label3);
            this.tabRedefinirEmail.Controls.Add(this.txtEmailAtual);
            this.tabRedefinirEmail.Controls.Add(this.label2);
            this.tabRedefinirEmail.Controls.Add(this.label1);
            this.tabRedefinirEmail.Location = new System.Drawing.Point(4, 22);
            this.tabRedefinirEmail.Name = "tabRedefinirEmail";
            this.tabRedefinirEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tabRedefinirEmail.Size = new System.Drawing.Size(824, 468);
            this.tabRedefinirEmail.TabIndex = 1;
            this.tabRedefinirEmail.Text = "Redefinir Email";
            // 
            // btnCancelAlterEmail
            // 
            this.btnCancelAlterEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelAlterEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelAlterEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancelAlterEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAlterEmail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAlterEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelAlterEmail.Location = new System.Drawing.Point(131, 236);
            this.btnCancelAlterEmail.Name = "btnCancelAlterEmail";
            this.btnCancelAlterEmail.Size = new System.Drawing.Size(118, 32);
            this.btnCancelAlterEmail.TabIndex = 5;
            this.btnCancelAlterEmail.Text = "Cancelar";
            this.btnCancelAlterEmail.UseVisualStyleBackColor = false;
            this.btnCancelAlterEmail.Click += new System.EventHandler(this.btnCancelAlterEmail_Click);
            // 
            // btnAlterarEmail
            // 
            this.btnAlterarEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAlterarEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAlterarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarEmail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAlterarEmail.Location = new System.Drawing.Point(7, 236);
            this.btnAlterarEmail.Name = "btnAlterarEmail";
            this.btnAlterarEmail.Size = new System.Drawing.Size(118, 32);
            this.btnAlterarEmail.TabIndex = 4;
            this.btnAlterarEmail.Text = "Salvar";
            this.btnAlterarEmail.UseVisualStyleBackColor = false;
            this.btnAlterarEmail.Click += new System.EventHandler(this.btnAlterarEmail_Click);
            // 
            // txtSenhaUsuario_tabAlterEmail
            // 
            this.txtSenhaUsuario_tabAlterEmail.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaUsuario_tabAlterEmail.Location = new System.Drawing.Point(7, 180);
            this.txtSenhaUsuario_tabAlterEmail.Name = "txtSenhaUsuario_tabAlterEmail";
            this.txtSenhaUsuario_tabAlterEmail.PasswordChar = '●';
            this.txtSenhaUsuario_tabAlterEmail.Size = new System.Drawing.Size(378, 26);
            this.txtSenhaUsuario_tabAlterEmail.TabIndex = 3;
            // 
            // txtNovoEmail
            // 
            this.txtNovoEmail.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovoEmail.Location = new System.Drawing.Point(7, 109);
            this.txtNovoEmail.Name = "txtNovoEmail";
            this.txtNovoEmail.Size = new System.Drawing.Size(378, 26);
            this.txtNovoEmail.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Digite sua senha para confirmação:";
            // 
            // txtEmailAtual
            // 
            this.txtEmailAtual.Enabled = false;
            this.txtEmailAtual.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAtual.Location = new System.Drawing.Point(7, 39);
            this.txtEmailAtual.Name = "txtEmailAtual";
            this.txtEmailAtual.Size = new System.Drawing.Size(378, 26);
            this.txtEmailAtual.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Novo E-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-mail atual";
            // 
            // tabRedefinirNomeUsuario
            // 
            this.tabRedefinirNomeUsuario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabRedefinirNomeUsuario.Controls.Add(this.btnCancelAlterLogin);
            this.tabRedefinirNomeUsuario.Controls.Add(this.btnAlterarNomeLogin);
            this.tabRedefinirNomeUsuario.Controls.Add(this.txtSenhaUsuario_tabAlterLogin);
            this.tabRedefinirNomeUsuario.Controls.Add(this.txtNovoNomeLogin);
            this.tabRedefinirNomeUsuario.Controls.Add(this.label5);
            this.tabRedefinirNomeUsuario.Controls.Add(this.txtNomeLoginAtual);
            this.tabRedefinirNomeUsuario.Controls.Add(this.label6);
            this.tabRedefinirNomeUsuario.Controls.Add(this.label10);
            this.tabRedefinirNomeUsuario.Location = new System.Drawing.Point(4, 22);
            this.tabRedefinirNomeUsuario.Name = "tabRedefinirNomeUsuario";
            this.tabRedefinirNomeUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabRedefinirNomeUsuario.Size = new System.Drawing.Size(824, 468);
            this.tabRedefinirNomeUsuario.TabIndex = 2;
            this.tabRedefinirNomeUsuario.Text = "Redefinir Nome Login";
            // 
            // btnCancelAlterLogin
            // 
            this.btnCancelAlterLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelAlterLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelAlterLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancelAlterLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAlterLogin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAlterLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelAlterLogin.Location = new System.Drawing.Point(132, 238);
            this.btnCancelAlterLogin.Name = "btnCancelAlterLogin";
            this.btnCancelAlterLogin.Size = new System.Drawing.Size(118, 32);
            this.btnCancelAlterLogin.TabIndex = 5;
            this.btnCancelAlterLogin.Text = "Cancelar";
            this.btnCancelAlterLogin.UseVisualStyleBackColor = false;
            this.btnCancelAlterLogin.Click += new System.EventHandler(this.btnCancelAlterLogin_Click);
            // 
            // btnAlterarNomeLogin
            // 
            this.btnAlterarNomeLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAlterarNomeLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarNomeLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAlterarNomeLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarNomeLogin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarNomeLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAlterarNomeLogin.Location = new System.Drawing.Point(8, 238);
            this.btnAlterarNomeLogin.Name = "btnAlterarNomeLogin";
            this.btnAlterarNomeLogin.Size = new System.Drawing.Size(118, 32);
            this.btnAlterarNomeLogin.TabIndex = 4;
            this.btnAlterarNomeLogin.Text = "Salvar";
            this.btnAlterarNomeLogin.UseVisualStyleBackColor = false;
            this.btnAlterarNomeLogin.Click += new System.EventHandler(this.btnAlterarNomeLogin_Click);
            // 
            // txtSenhaUsuario_tabAlterLogin
            // 
            this.txtSenhaUsuario_tabAlterLogin.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaUsuario_tabAlterLogin.Location = new System.Drawing.Point(8, 182);
            this.txtSenhaUsuario_tabAlterLogin.Name = "txtSenhaUsuario_tabAlterLogin";
            this.txtSenhaUsuario_tabAlterLogin.PasswordChar = '*';
            this.txtSenhaUsuario_tabAlterLogin.Size = new System.Drawing.Size(378, 26);
            this.txtSenhaUsuario_tabAlterLogin.TabIndex = 3;
            // 
            // txtNovoNomeLogin
            // 
            this.txtNovoNomeLogin.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovoNomeLogin.Location = new System.Drawing.Point(8, 111);
            this.txtNovoNomeLogin.Name = "txtNovoNomeLogin";
            this.txtNovoNomeLogin.Size = new System.Drawing.Size(378, 26);
            this.txtNovoNomeLogin.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Digite sua senha para confirmação:";
            // 
            // txtNomeLoginAtual
            // 
            this.txtNomeLoginAtual.Enabled = false;
            this.txtNomeLoginAtual.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLoginAtual.Location = new System.Drawing.Point(8, 41);
            this.txtNomeLoginAtual.Name = "txtNomeLoginAtual";
            this.txtNomeLoginAtual.Size = new System.Drawing.Size(378, 26);
            this.txtNomeLoginAtual.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Novo login de Usuario:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nome login atual:";
            // 
            // FrmSegUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(832, 494);
            this.Controls.Add(this.tbcSeguranca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSegUsuario";
            this.Text = "FrmSegUsuario";
            this.Load += new System.EventHandler(this.FrmSegUsuario_Load);
            this.tbcSeguranca.ResumeLayout(false);
            this.tabRedefinirSenha.ResumeLayout(false);
            this.tabRedefinirSenha.PerformLayout();
            this.tabRedefinirEmail.ResumeLayout(false);
            this.tabRedefinirEmail.PerformLayout();
            this.tabRedefinirNomeUsuario.ResumeLayout(false);
            this.tabRedefinirNomeUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcSeguranca;
        private System.Windows.Forms.TabPage tabRedefinirSenha;
        private System.Windows.Forms.TextBox txtNovaSenha2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNovaSenha1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAlterarSenha;
        private System.Windows.Forms.TabPage tabRedefinirEmail;
        private System.Windows.Forms.Button btnAlterarEmail;
        private System.Windows.Forms.TextBox txtSenhaUsuario_tabAlterEmail;
        private System.Windows.Forms.TextBox txtNovoEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailAtual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabRedefinirNomeUsuario;
        private System.Windows.Forms.Button btnAlterarNomeLogin;
        private System.Windows.Forms.TextBox txtSenhaUsuario_tabAlterLogin;
        private System.Windows.Forms.TextBox txtNovoNomeLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeLoginAtual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnConferirSenha;
        private System.Windows.Forms.Button btnCancelAlterSenha;
        private System.Windows.Forms.CheckBox CBMostrarSenha;
        private System.Windows.Forms.Button btnCancelAlterEmail;
        private System.Windows.Forms.Button btnCancelAlterLogin;
    }
}