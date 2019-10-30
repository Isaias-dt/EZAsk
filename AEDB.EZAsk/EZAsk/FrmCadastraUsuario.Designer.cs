namespace EZAsk
{
    partial class FrmCadastraUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.txtNomeLogin = new System.Windows.Forms.TextBox();
            this.txtEmailUsuario = new System.Windows.Forms.TextBox();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.btnCadastraUsuario = new System.Windows.Forms.Button();
            this.LblInfEmailUsuario = new System.Windows.Forms.Label();
            this.pnlHeaderCadUsuario = new System.Windows.Forms.Panel();
            this.lblInfNomeLogin = new System.Windows.Forms.Label();
            this.lblInfNomeUsuario = new System.Windows.Forms.Label();
            this.pnlHeaderCadUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(176, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastre - se";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Usuário:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Senha:";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeUsuario.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuario.Location = new System.Drawing.Point(72, 84);
            this.txtNomeUsuario.MaxLength = 100;
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(356, 26);
            this.txtNomeUsuario.TabIndex = 0;
            this.txtNomeUsuario.Leave += new System.EventHandler(this.txtNomeUsuario_Leave);
            // 
            // txtNomeLogin
            // 
            this.txtNomeLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeLogin.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLogin.Location = new System.Drawing.Point(71, 148);
            this.txtNomeLogin.MaxLength = 50;
            this.txtNomeLogin.Name = "txtNomeLogin";
            this.txtNomeLogin.Size = new System.Drawing.Size(356, 26);
            this.txtNomeLogin.TabIndex = 1;
            this.txtNomeLogin.Leave += new System.EventHandler(this.txtNomeLogin_Leave);
            // 
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailUsuario.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailUsuario.Location = new System.Drawing.Point(71, 213);
            this.txtEmailUsuario.MaxLength = 100;
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.Size = new System.Drawing.Size(356, 26);
            this.txtEmailUsuario.TabIndex = 2;
            this.txtEmailUsuario.Leave += new System.EventHandler(this.txtEmailUsuario_Leave);
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenhaUsuario.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaUsuario.Location = new System.Drawing.Point(71, 275);
            this.txtSenhaUsuario.MaxLength = 100;
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.PasswordChar = '●';
            this.txtSenhaUsuario.Size = new System.Drawing.Size(356, 26);
            this.txtSenhaUsuario.TabIndex = 3;
            this.txtSenhaUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenhaUsuario_KeyPress);
            // 
            // btnCadastraUsuario
            // 
            this.btnCadastraUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastraUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastraUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCadastraUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastraUsuario.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastraUsuario.Location = new System.Drawing.Point(185, 332);
            this.btnCadastraUsuario.Name = "btnCadastraUsuario";
            this.btnCadastraUsuario.Size = new System.Drawing.Size(118, 32);
            this.btnCadastraUsuario.TabIndex = 4;
            this.btnCadastraUsuario.Text = "Cadastrar";
            this.btnCadastraUsuario.UseVisualStyleBackColor = true;
            this.btnCadastraUsuario.Click += new System.EventHandler(this.btnCadastraUsuario_Click);
            // 
            // LblInfEmailUsuario
            // 
            this.LblInfEmailUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblInfEmailUsuario.AutoSize = true;
            this.LblInfEmailUsuario.ForeColor = System.Drawing.Color.Red;
            this.LblInfEmailUsuario.Location = new System.Drawing.Point(69, 242);
            this.LblInfEmailUsuario.Name = "LblInfEmailUsuario";
            this.LblInfEmailUsuario.Size = new System.Drawing.Size(0, 13);
            this.LblInfEmailUsuario.TabIndex = 5;
            this.LblInfEmailUsuario.Visible = false;
            // 
            // pnlHeaderCadUsuario
            // 
            this.pnlHeaderCadUsuario.BackColor = System.Drawing.Color.Teal;
            this.pnlHeaderCadUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeaderCadUsuario.Controls.Add(this.label1);
            this.pnlHeaderCadUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderCadUsuario.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderCadUsuario.Name = "pnlHeaderCadUsuario";
            this.pnlHeaderCadUsuario.Size = new System.Drawing.Size(491, 45);
            this.pnlHeaderCadUsuario.TabIndex = 6;
            // 
            // lblInfNomeLogin
            // 
            this.lblInfNomeLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInfNomeLogin.AutoSize = true;
            this.lblInfNomeLogin.ForeColor = System.Drawing.Color.Red;
            this.lblInfNomeLogin.Location = new System.Drawing.Point(69, 179);
            this.lblInfNomeLogin.Name = "lblInfNomeLogin";
            this.lblInfNomeLogin.Size = new System.Drawing.Size(0, 13);
            this.lblInfNomeLogin.TabIndex = 5;
            this.lblInfNomeLogin.Visible = false;
            // 
            // lblInfNomeUsuario
            // 
            this.lblInfNomeUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInfNomeUsuario.AutoSize = true;
            this.lblInfNomeUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblInfNomeUsuario.Location = new System.Drawing.Point(69, 114);
            this.lblInfNomeUsuario.Name = "lblInfNomeUsuario";
            this.lblInfNomeUsuario.Size = new System.Drawing.Size(0, 13);
            this.lblInfNomeUsuario.TabIndex = 5;
            this.lblInfNomeUsuario.Visible = false;
            // 
            // FrmCadastraUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(491, 376);
            this.Controls.Add(this.pnlHeaderCadUsuario);
            this.Controls.Add(this.lblInfNomeUsuario);
            this.Controls.Add(this.lblInfNomeLogin);
            this.Controls.Add(this.LblInfEmailUsuario);
            this.Controls.Add(this.btnCadastraUsuario);
            this.Controls.Add(this.txtSenhaUsuario);
            this.Controls.Add(this.txtEmailUsuario);
            this.Controls.Add(this.txtNomeLogin);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmCadastraUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Usuário";
            this.pnlHeaderCadUsuario.ResumeLayout(false);
            this.pnlHeaderCadUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.TextBox txtNomeLogin;
        private System.Windows.Forms.TextBox txtEmailUsuario;
        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.Button btnCadastraUsuario;
        private System.Windows.Forms.Label LblInfEmailUsuario;
        private System.Windows.Forms.Panel pnlHeaderCadUsuario;
        private System.Windows.Forms.Label lblInfNomeLogin;
        private System.Windows.Forms.Label lblInfNomeUsuario;
    }
}