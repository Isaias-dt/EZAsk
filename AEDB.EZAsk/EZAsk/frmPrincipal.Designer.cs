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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuFrmPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuForum = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.menuFrmPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuFrmPrincipal
            // 
            this.menuFrmPrincipal.AutoSize = false;
            this.menuFrmPrincipal.BackColor = System.Drawing.Color.Teal;
            this.menuFrmPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuFrmPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogin,
            this.menuCadastra,
            this.menuForum,
            this.menuSobre});
            this.menuFrmPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuFrmPrincipal.Name = "menuFrmPrincipal";
            this.menuFrmPrincipal.Padding = new System.Windows.Forms.Padding(3, 8, 2, 2);
            this.menuFrmPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuFrmPrincipal.Size = new System.Drawing.Size(159, 450);
            this.menuFrmPrincipal.TabIndex = 0;
            this.menuFrmPrincipal.Text = "menuPrincipal";
            // 
            // menuLogin
            // 
            this.menuLogin.AutoSize = false;
            this.menuLogin.BackColor = System.Drawing.Color.Teal;
            this.menuLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.menuLogin.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Size = new System.Drawing.Size(159, 40);
            this.menuLogin.Text = "Login";
            this.menuLogin.Click += new System.EventHandler(this.menuLogin_Click);
            // 
            // menuCadastra
            // 
            this.menuCadastra.AutoSize = false;
            this.menuCadastra.BackColor = System.Drawing.Color.Teal;
            this.menuCadastra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCadastra.ForeColor = System.Drawing.SystemColors.Control;
            this.menuCadastra.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.menuCadastra.Name = "menuCadastra";
            this.menuCadastra.Size = new System.Drawing.Size(159, 40);
            this.menuCadastra.Text = "Cadastrar";
            this.menuCadastra.Click += new System.EventHandler(this.menuCadastra_Click);
            // 
            // menuForum
            // 
            this.menuForum.AutoSize = false;
            this.menuForum.BackColor = System.Drawing.Color.Teal;
            this.menuForum.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.menuForum.ForeColor = System.Drawing.SystemColors.Control;
            this.menuForum.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.menuForum.Name = "menuForum";
            this.menuForum.Size = new System.Drawing.Size(159, 40);
            this.menuForum.Text = "Forum";
            this.menuForum.Click += new System.EventHandler(this.menuForum_Click);
            // 
            // menuSobre
            // 
            this.menuSobre.AutoSize = false;
            this.menuSobre.BackColor = System.Drawing.Color.Teal;
            this.menuSobre.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.menuSobre.ForeColor = System.Drawing.SystemColors.Control;
            this.menuSobre.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.menuSobre.Name = "menuSobre";
            this.menuSobre.Size = new System.Drawing.Size(159, 40);
            this.menuSobre.Text = "Sobre";
            this.menuSobre.Click += new System.EventHandler(this.menuSobre_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackgroundImage = global::EZAsk.Properties.Resources.imgFundo;
            this.pnlPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlPrincipal.Location = new System.Drawing.Point(159, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(641, 450);
            this.pnlPrincipal.TabIndex = 2;
            this.pnlPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPrincipal_Paint);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.menuFrmPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuFrmPrincipal;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FrmPrincipal";
            this.Text = "EZAsk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuFrmPrincipal.ResumeLayout(false);
            this.menuFrmPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ToolStripMenuItem menuLogin;
        public System.Windows.Forms.ToolStripMenuItem menuCadastra;
        public System.Windows.Forms.ToolStripMenuItem menuForum;
        public System.Windows.Forms.ToolStripMenuItem menuSobre;
        public System.Windows.Forms.MenuStrip menuFrmPrincipal;
        public System.Windows.Forms.Panel pnlPrincipal;
    }
}

