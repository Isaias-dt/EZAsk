namespace EZAsk
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuFrmPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuForum = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFrmPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuFrmPrincipal
            // 
            this.menuFrmPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogin,
            this.menuCadastra,
            this.menuForum,
            this.menuSobre});
            this.menuFrmPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuFrmPrincipal.Name = "menuFrmPrincipal";
            this.menuFrmPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menuFrmPrincipal.TabIndex = 0;
            this.menuFrmPrincipal.Text = "menuStrip1";
            // 
            // menuLogin
            // 
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Size = new System.Drawing.Size(49, 20);
            this.menuLogin.Text = "Login";
            this.menuLogin.Click += new System.EventHandler(this.menuLogin_Click);
            // 
            // menuCadastra
            // 
            this.menuCadastra.Name = "menuCadastra";
            this.menuCadastra.Size = new System.Drawing.Size(69, 20);
            this.menuCadastra.Text = "Cadastrar";
            this.menuCadastra.Click += new System.EventHandler(this.menuCadastra_Click);
            // 
            // menuForum
            // 
            this.menuForum.Name = "menuForum";
            this.menuForum.Size = new System.Drawing.Size(54, 20);
            this.menuForum.Text = "Forum";
            this.menuForum.Click += new System.EventHandler(this.menuForum_Click);
            // 
            // menuSobre
            // 
            this.menuSobre.Name = "menuSobre";
            this.menuSobre.Size = new System.Drawing.Size(49, 20);
            this.menuSobre.Text = "Sobre";
            this.menuSobre.Click += new System.EventHandler(this.menuSobre_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EZAsk.Properties.Resources.imgFundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuFrmPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuFrmPrincipal;
            this.Name = "FrmPrincipal";
            this.Text = "EZAsk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuFrmPrincipal.ResumeLayout(false);
            this.menuFrmPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ToolStripMenuItem menuLogin;
        public System.Windows.Forms.ToolStripMenuItem menuCadastra;
        public System.Windows.Forms.ToolStripMenuItem menuForum;
        public System.Windows.Forms.ToolStripMenuItem menuSobre;
        public System.Windows.Forms.MenuStrip menuFrmPrincipal;
    }
}

