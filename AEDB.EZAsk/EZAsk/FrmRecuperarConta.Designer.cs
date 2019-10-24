namespace EZAsk
{
    partial class FrmRecuperarConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecuperarConta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LblInfEmailUsuario = new System.Windows.Forms.Label();
            this.txtEmailUsuario = new System.Windows.Forms.TextBox();
            this.lblEmailUsuario = new System.Windows.Forms.Label();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.lblInfEmailEnviado = new System.Windows.Forms.Label();
            this.pbGifCarregando = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGifCarregando)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 45);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(215, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recuperar Conta";
            // 
            // LblInfEmailUsuario
            // 
            this.LblInfEmailUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblInfEmailUsuario.AutoSize = true;
            this.LblInfEmailUsuario.ForeColor = System.Drawing.Color.Red;
            this.LblInfEmailUsuario.Location = new System.Drawing.Point(121, 118);
            this.LblInfEmailUsuario.Name = "LblInfEmailUsuario";
            this.LblInfEmailUsuario.Size = new System.Drawing.Size(0, 13);
            this.LblInfEmailUsuario.TabIndex = 8;
            this.LblInfEmailUsuario.Visible = false;
            // 
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmailUsuario.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailUsuario.Location = new System.Drawing.Point(123, 89);
            this.txtEmailUsuario.MaxLength = 100;
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.Size = new System.Drawing.Size(356, 26);
            this.txtEmailUsuario.TabIndex = 7;
            this.txtEmailUsuario.Leave += new System.EventHandler(this.txtEmailUsuario_Leave);
            // 
            // lblEmailUsuario
            // 
            this.lblEmailUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmailUsuario.AutoSize = true;
            this.lblEmailUsuario.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailUsuario.Location = new System.Drawing.Point(120, 68);
            this.lblEmailUsuario.Name = "lblEmailUsuario";
            this.lblEmailUsuario.Size = new System.Drawing.Size(54, 18);
            this.lblEmailUsuario.TabIndex = 6;
            this.lblEmailUsuario.Text = "Email:";
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEnviarEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnEnviarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarEmail.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarEmail.Location = new System.Drawing.Point(123, 134);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(118, 32);
            this.btnEnviarEmail.TabIndex = 9;
            this.btnEnviarEmail.Text = "Enviar";
            this.btnEnviarEmail.UseVisualStyleBackColor = true;
            this.btnEnviarEmail.Click += new System.EventHandler(this.btnEnviarEmail_Click);
            // 
            // lblInfEmailEnviado
            // 
            this.lblInfEmailEnviado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInfEmailEnviado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfEmailEnviado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfEmailEnviado.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblInfEmailEnviado.Location = new System.Drawing.Point(121, 184);
            this.lblInfEmailEnviado.Name = "lblInfEmailEnviado";
            this.lblInfEmailEnviado.Size = new System.Drawing.Size(359, 169);
            this.lblInfEmailEnviado.TabIndex = 10;
            this.lblInfEmailEnviado.Visible = false;
            // 
            // pbGifCarregando
            // 
            this.pbGifCarregando.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbGifCarregando.Image = ((System.Drawing.Image)(resources.GetObject("pbGifCarregando.Image")));
            this.pbGifCarregando.Location = new System.Drawing.Point(247, 132);
            this.pbGifCarregando.Name = "pbGifCarregando";
            this.pbGifCarregando.Size = new System.Drawing.Size(36, 34);
            this.pbGifCarregando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGifCarregando.TabIndex = 11;
            this.pbGifCarregando.TabStop = false;
            this.pbGifCarregando.Visible = false;
            // 
            // FrmRecuperarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(605, 391);
            this.Controls.Add(this.pbGifCarregando);
            this.Controls.Add(this.lblInfEmailEnviado);
            this.Controls.Add(this.btnEnviarEmail);
            this.Controls.Add(this.LblInfEmailUsuario);
            this.Controls.Add(this.txtEmailUsuario);
            this.Controls.Add(this.lblEmailUsuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRecuperarConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar Email e Senha";
            this.Load += new System.EventHandler(this.FrmRecuperarConta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGifCarregando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblInfEmailUsuario;
        private System.Windows.Forms.TextBox txtEmailUsuario;
        private System.Windows.Forms.Label lblEmailUsuario;
        private System.Windows.Forms.Button btnEnviarEmail;
        private System.Windows.Forms.Label lblInfEmailEnviado;
        private System.Windows.Forms.PictureBox pbGifCarregando;
    }
}