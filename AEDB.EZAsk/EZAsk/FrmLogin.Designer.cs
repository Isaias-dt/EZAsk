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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnCadastreSe = new System.Windows.Forms.Button();
            this.lblTrocarSenha = new System.Windows.Forms.Label();
            this.txtAltUsuario = new System.Windows.Forms.TextBox();
            this.txtAltSenha = new System.Windows.Forms.TextBox();
            this.imgLoginPadrao = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoginPadrao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(49, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome de Usuário ou Email:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(49, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnEntrar.Location = new System.Drawing.Point(129, 371);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(118, 32);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnCadastreSe
            // 
            this.btnCadastreSe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastreSe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastreSe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCadastreSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastreSe.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastreSe.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCadastreSe.Location = new System.Drawing.Point(129, 419);
            this.btnCadastreSe.Name = "btnCadastreSe";
            this.btnCadastreSe.Size = new System.Drawing.Size(118, 32);
            this.btnCadastreSe.TabIndex = 4;
            this.btnCadastreSe.Text = "Cadastre - se";
            this.btnCadastreSe.UseVisualStyleBackColor = true;
            this.btnCadastreSe.Click += new System.EventHandler(this.btnCadastreSe_Click);
            // 
            // lblTrocarSenha
            // 
            this.lblTrocarSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTrocarSenha.AutoSize = true;
            this.lblTrocarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTrocarSenha.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrocarSenha.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTrocarSenha.Location = new System.Drawing.Point(49, 320);
            this.lblTrocarSenha.Name = "lblTrocarSenha";
            this.lblTrocarSenha.Size = new System.Drawing.Size(171, 13);
            this.lblTrocarSenha.TabIndex = 0;
            this.lblTrocarSenha.Text = "Esqueceu a Senha ou Email?";
            this.lblTrocarSenha.Visible = false;
            this.lblTrocarSenha.MouseEnter += new System.EventHandler(this.lblTrocarSenha_MouseEnter);
            this.lblTrocarSenha.MouseLeave += new System.EventHandler(this.lblTrocarSenha_MouseLeave);
            // 
            // txtAltUsuario
            // 
            this.txtAltUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAltUsuario.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltUsuario.Location = new System.Drawing.Point(52, 237);
            this.txtAltUsuario.MaxLength = 50;
            this.txtAltUsuario.Name = "txtAltUsuario";
            this.txtAltUsuario.Size = new System.Drawing.Size(270, 26);
            this.txtAltUsuario.TabIndex = 1;
            // 
            // txtAltSenha
            // 
            this.txtAltSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAltSenha.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltSenha.Location = new System.Drawing.Point(52, 291);
            this.txtAltSenha.MaxLength = 100;
            this.txtAltSenha.Name = "txtAltSenha";
            this.txtAltSenha.PasswordChar = '●';
            this.txtAltSenha.Size = new System.Drawing.Size(270, 26);
            this.txtAltSenha.TabIndex = 2;
            // 
            // imgLoginPadrao
            // 
            this.imgLoginPadrao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgLoginPadrao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgLoginPadrao.Image = global::EZAsk.Properties.Resources.imgLoginPadrao;
            this.imgLoginPadrao.Location = new System.Drawing.Point(108, 38);
            this.imgLoginPadrao.Name = "imgLoginPadrao";
            this.imgLoginPadrao.Size = new System.Drawing.Size(159, 138);
            this.imgLoginPadrao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLoginPadrao.TabIndex = 2;
            this.imgLoginPadrao.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(374, 478);
            this.Controls.Add(this.txtAltSenha);
            this.Controls.Add(this.txtAltUsuario);
            this.Controls.Add(this.lblTrocarSenha);
            this.Controls.Add(this.btnCadastreSe);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.imgLoginPadrao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.TopMost = true;
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
        private System.Windows.Forms.Label lblTrocarSenha;
        private System.Windows.Forms.TextBox txtAltUsuario;
        private System.Windows.Forms.TextBox txtAltSenha;
    }
}