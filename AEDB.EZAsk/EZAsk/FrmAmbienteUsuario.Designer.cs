namespace EZAsk
{
    partial class FrmAmbienteUsuario
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
            this.btnDeslogarUsuario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pagUsuario = new System.Windows.Forms.TabControl();
            this.tabPagPerfil = new System.Windows.Forms.TabPage();
            this.tabPagDuvida = new System.Windows.Forms.TabPage();
            this.tabPagResposta = new System.Windows.Forms.TabPage();
            this.tabPagForum = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pagUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeslogarUsuario
            // 
            this.btnDeslogarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeslogarUsuario.Location = new System.Drawing.Point(724, 92);
            this.btnDeslogarUsuario.Name = "btnDeslogarUsuario";
            this.btnDeslogarUsuario.Size = new System.Drawing.Size(64, 20);
            this.btnDeslogarUsuario.TabIndex = 2;
            this.btnDeslogarUsuario.Text = "Sair";
            this.btnDeslogarUsuario.UseVisualStyleBackColor = true;
            this.btnDeslogarUsuario.Click += new System.EventHandler(this.btnDeslogarUsuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::EZAsk.Properties.Resources.imgLoginPadrao;
            this.pictureBox1.InitialImage = global::EZAsk.Properties.Resources.imgLoginPadrao;
            this.pictureBox1.Location = new System.Drawing.Point(724, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pagUsuario
            // 
            this.pagUsuario.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.pagUsuario.Controls.Add(this.tabPagPerfil);
            this.pagUsuario.Controls.Add(this.tabPagDuvida);
            this.pagUsuario.Controls.Add(this.tabPagResposta);
            this.pagUsuario.Controls.Add(this.tabPagForum);
            this.pagUsuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.pagUsuario.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pagUsuario.Location = new System.Drawing.Point(0, 0);
            this.pagUsuario.Multiline = true;
            this.pagUsuario.Name = "pagUsuario";
            this.pagUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pagUsuario.SelectedIndex = 0;
            this.pagUsuario.Size = new System.Drawing.Size(718, 515);
            this.pagUsuario.TabIndex = 3;
            // 
            // tabPagPerfil
            // 
            this.tabPagPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPagPerfil.Location = new System.Drawing.Point(4, 28);
            this.tabPagPerfil.Name = "tabPagPerfil";
            this.tabPagPerfil.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagPerfil.Size = new System.Drawing.Size(710, 483);
            this.tabPagPerfil.TabIndex = 0;
            this.tabPagPerfil.Text = "Perfil";
            this.tabPagPerfil.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPagDuvida
            // 
            this.tabPagDuvida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPagDuvida.Location = new System.Drawing.Point(4, 28);
            this.tabPagDuvida.Name = "tabPagDuvida";
            this.tabPagDuvida.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagDuvida.Size = new System.Drawing.Size(710, 483);
            this.tabPagDuvida.TabIndex = 1;
            this.tabPagDuvida.Text = "Suas Dúvidas";
            // 
            // tabPagResposta
            // 
            this.tabPagResposta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPagResposta.Location = new System.Drawing.Point(4, 28);
            this.tabPagResposta.Name = "tabPagResposta";
            this.tabPagResposta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagResposta.Size = new System.Drawing.Size(710, 483);
            this.tabPagResposta.TabIndex = 2;
            this.tabPagResposta.Text = "Suas Respostas";
            // 
            // tabPagForum
            // 
            this.tabPagForum.Location = new System.Drawing.Point(4, 28);
            this.tabPagForum.Name = "tabPagForum";
            this.tabPagForum.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagForum.Size = new System.Drawing.Size(710, 483);
            this.tabPagForum.TabIndex = 3;
            this.tabPagForum.Text = "Forum";
            this.tabPagForum.UseVisualStyleBackColor = true;
            // 
            // FrmAmbienteUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDeslogarUsuario);
            this.Controls.Add(this.pagUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAmbienteUsuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmAmbienteUsuario_Activated);
            this.Load += new System.EventHandler(this.FrmAmbienteUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pagUsuario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDeslogarUsuario;
        private System.Windows.Forms.TabControl pagUsuario;
        private System.Windows.Forms.TabPage tabPagPerfil;
        private System.Windows.Forms.TabPage tabPagDuvida;
        private System.Windows.Forms.TabPage tabPagForum;
        private System.Windows.Forms.TabPage tabPagResposta;
    }
}