namespace EZAsk
{
    partial class FrmLogin
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
            this.imgLoginPadrao = new System.Windows.Forms.PictureBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnCadastreSe = new System.Windows.Forms.Button();
            this.trocarSenha = new System.Windows.Forms.Label();
            this.txtAltUsuario = new System.Windows.Forms.TextBox();
            this.txtAltSenha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoginPadrao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome de Usuário ou Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // imgLoginPadrao
            // 
            this.imgLoginPadrao.Image = global::EZAsk.Properties.Resources.imgLoginPadrao;
            this.imgLoginPadrao.Location = new System.Drawing.Point(125, 42);
            this.imgLoginPadrao.Name = "imgLoginPadrao";
            this.imgLoginPadrao.Size = new System.Drawing.Size(159, 138);
            this.imgLoginPadrao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLoginPadrao.TabIndex = 2;
            this.imgLoginPadrao.TabStop = false;
            this.imgLoginPadrao.Click += new System.EventHandler(this.imgLoginPadrao_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(149, 341);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(118, 32);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnCadastreSe
            // 
            this.btnCadastreSe.Location = new System.Drawing.Point(149, 389);
            this.btnCadastreSe.Name = "btnCadastreSe";
            this.btnCadastreSe.Size = new System.Drawing.Size(118, 32);
            this.btnCadastreSe.TabIndex = 6;
            this.btnCadastreSe.Text = "Cadastre - se";
            this.btnCadastreSe.UseVisualStyleBackColor = true;
            this.btnCadastreSe.Click += new System.EventHandler(this.btnCadastreSe_Click);
            // 
            // trocarSenha
            // 
            this.trocarSenha.AutoSize = true;
            this.trocarSenha.ForeColor = System.Drawing.Color.RoyalBlue;
            this.trocarSenha.Location = new System.Drawing.Point(66, 313);
            this.trocarSenha.Name = "trocarSenha";
            this.trocarSenha.Size = new System.Drawing.Size(102, 13);
            this.trocarSenha.TabIndex = 4;
            this.trocarSenha.Text = "Esqueceu a senha?";
            this.trocarSenha.Visible = false;
            // 
            // txtAltUsuario
            // 
            this.txtAltUsuario.Location = new System.Drawing.Point(69, 237);
            this.txtAltUsuario.Name = "txtAltUsuario";
            this.txtAltUsuario.Size = new System.Drawing.Size(270, 20);
            this.txtAltUsuario.TabIndex = 7;
            this.txtAltUsuario.Leave += new System.EventHandler(this.txtAltUsuario_Leave);
            // 
            // txtAltSenha
            // 
            this.txtAltSenha.Location = new System.Drawing.Point(69, 290);
            this.txtAltSenha.Name = "txtAltSenha";
            this.txtAltSenha.PasswordChar = '●';
            this.txtAltSenha.Size = new System.Drawing.Size(270, 20);
            this.txtAltSenha.TabIndex = 7;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 501);
            this.Controls.Add(this.txtAltSenha);
            this.Controls.Add(this.txtAltUsuario);
            this.Controls.Add(this.trocarSenha);
            this.Controls.Add(this.btnCadastreSe);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.imgLoginPadrao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLoginPadrao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imgLoginPadrao;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCadastreSe;
        private System.Windows.Forms.Label trocarSenha;
        private System.Windows.Forms.TextBox txtAltUsuario;
        private System.Windows.Forms.TextBox txtAltSenha;
    }
}