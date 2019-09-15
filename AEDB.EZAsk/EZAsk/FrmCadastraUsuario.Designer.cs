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
            this.infLabelEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastre - se";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Usuário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Senha:";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(70, 84);
            this.txtNomeUsuario.MaxLength = 50;
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(356, 20);
            this.txtNomeUsuario.TabIndex = 0;
            // 
            // txtNomeLogin
            // 
            this.txtNomeLogin.Location = new System.Drawing.Point(70, 137);
            this.txtNomeLogin.MaxLength = 50;
            this.txtNomeLogin.Name = "txtNomeLogin";
            this.txtNomeLogin.Size = new System.Drawing.Size(356, 20);
            this.txtNomeLogin.TabIndex = 1;
            // 
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.Location = new System.Drawing.Point(70, 189);
            this.txtEmailUsuario.MaxLength = 50;
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.Size = new System.Drawing.Size(356, 20);
            this.txtEmailUsuario.TabIndex = 2;
            this.txtEmailUsuario.Leave += new System.EventHandler(this.txtEmailUsuario_Leave);
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Location = new System.Drawing.Point(70, 238);
            this.txtSenhaUsuario.MaxLength = 100;
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.PasswordChar = '●';
            this.txtSenhaUsuario.Size = new System.Drawing.Size(356, 20);
            this.txtSenhaUsuario.TabIndex = 3;
            // 
            // btnCadastraUsuario
            // 
            this.btnCadastraUsuario.Location = new System.Drawing.Point(187, 298);
            this.btnCadastraUsuario.Name = "btnCadastraUsuario";
            this.btnCadastraUsuario.Size = new System.Drawing.Size(118, 32);
            this.btnCadastraUsuario.TabIndex = 4;
            this.btnCadastraUsuario.Text = "Cadastrar";
            this.btnCadastraUsuario.UseVisualStyleBackColor = true;
            this.btnCadastraUsuario.Click += new System.EventHandler(this.btnCadastraUsuario_Click);
            // 
            // infLabelEmail
            // 
            this.infLabelEmail.AutoSize = true;
            this.infLabelEmail.ForeColor = System.Drawing.Color.Red;
            this.infLabelEmail.Location = new System.Drawing.Point(70, 209);
            this.infLabelEmail.Name = "infLabelEmail";
            this.infLabelEmail.Size = new System.Drawing.Size(0, 13);
            this.infLabelEmail.TabIndex = 5;
            // 
            // FrmCadastraUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 376);
            this.Controls.Add(this.infLabelEmail);
            this.Controls.Add(this.btnCadastraUsuario);
            this.Controls.Add(this.txtSenhaUsuario);
            this.Controls.Add(this.txtEmailUsuario);
            this.Controls.Add(this.txtNomeLogin);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCadastraUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Usuário";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCadastraUsuario_FormClosed);
            this.Load += new System.EventHandler(this.FrmCadastraUsuario_Load);
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
        private System.Windows.Forms.Label infLabelEmail;
    }
}