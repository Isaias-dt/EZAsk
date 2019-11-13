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
            this.pnlMenuPrincipal = new System.Windows.Forms.Panel();
            this.IconMenuPrincipal = new System.Windows.Forms.PictureBox();
            this.btnMenuSobre = new System.Windows.Forms.Button();
            this.btnMenuForum = new System.Windows.Forms.Button();
            this.btnMenuCadastro = new System.Windows.Forms.Button();
            this.btnMenuLogin = new System.Windows.Forms.Button();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.pnlMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconMenuPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuPrincipal
            // 
            this.pnlMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlMenuPrincipal.Controls.Add(this.IconMenuPrincipal);
            this.pnlMenuPrincipal.Controls.Add(this.btnMenuSobre);
            this.pnlMenuPrincipal.Controls.Add(this.btnMenuForum);
            this.pnlMenuPrincipal.Controls.Add(this.btnMenuCadastro);
            this.pnlMenuPrincipal.Controls.Add(this.btnMenuLogin);
            this.pnlMenuPrincipal.Controls.Add(this.shapeContainer1);
            this.pnlMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuPrincipal.Name = "pnlMenuPrincipal";
            this.pnlMenuPrincipal.Size = new System.Drawing.Size(170, 450);
            this.pnlMenuPrincipal.TabIndex = 0;
            // 
            // IconMenuPrincipal
            // 
            this.IconMenuPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.IconMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IconMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconMenuPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("IconMenuPrincipal.Image")));
            this.IconMenuPrincipal.Location = new System.Drawing.Point(4, 12);
            this.IconMenuPrincipal.Name = "IconMenuPrincipal";
            this.IconMenuPrincipal.Size = new System.Drawing.Size(35, 32);
            this.IconMenuPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconMenuPrincipal.TabIndex = 1;
            this.IconMenuPrincipal.TabStop = false;
            this.IconMenuPrincipal.Click += new System.EventHandler(this.IconMenuPrincipal_Click);
            this.IconMenuPrincipal.MouseEnter += new System.EventHandler(this.IconMenuPrincipal_MouseEnter);
            this.IconMenuPrincipal.MouseLeave += new System.EventHandler(this.IconMenuPrincipal_MouseLeave);
            // 
            // btnMenuSobre
            // 
            this.btnMenuSobre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMenuSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuSobre.FlatAppearance.BorderSize = 0;
            this.btnMenuSobre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMenuSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSobre.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSobre.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMenuSobre.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuSobre.Image")));
            this.btnMenuSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSobre.Location = new System.Drawing.Point(0, 209);
            this.btnMenuSobre.Name = "btnMenuSobre";
            this.btnMenuSobre.Size = new System.Drawing.Size(170, 42);
            this.btnMenuSobre.TabIndex = 0;
            this.btnMenuSobre.Text = "Sobre";
            this.btnMenuSobre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuSobre.UseVisualStyleBackColor = false;
            this.btnMenuSobre.Click += new System.EventHandler(this.btnMenuSobre_Click);
            // 
            // btnMenuForum
            // 
            this.btnMenuForum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMenuForum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuForum.FlatAppearance.BorderSize = 0;
            this.btnMenuForum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMenuForum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuForum.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuForum.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMenuForum.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuForum.Image")));
            this.btnMenuForum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuForum.Location = new System.Drawing.Point(0, 161);
            this.btnMenuForum.Name = "btnMenuForum";
            this.btnMenuForum.Size = new System.Drawing.Size(170, 42);
            this.btnMenuForum.TabIndex = 0;
            this.btnMenuForum.Text = "Forum";
            this.btnMenuForum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuForum.UseVisualStyleBackColor = false;
            this.btnMenuForum.Click += new System.EventHandler(this.btnMenuForum_Click);
            // 
            // btnMenuCadastro
            // 
            this.btnMenuCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMenuCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuCadastro.FlatAppearance.BorderSize = 0;
            this.btnMenuCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMenuCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCadastro.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCadastro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMenuCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuCadastro.Image")));
            this.btnMenuCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuCadastro.Location = new System.Drawing.Point(0, 113);
            this.btnMenuCadastro.Name = "btnMenuCadastro";
            this.btnMenuCadastro.Size = new System.Drawing.Size(170, 42);
            this.btnMenuCadastro.TabIndex = 0;
            this.btnMenuCadastro.Text = "Cadastro";
            this.btnMenuCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuCadastro.UseVisualStyleBackColor = false;
            this.btnMenuCadastro.Click += new System.EventHandler(this.btnMenuCadastro_Click);
            // 
            // btnMenuLogin
            // 
            this.btnMenuLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMenuLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuLogin.FlatAppearance.BorderSize = 0;
            this.btnMenuLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMenuLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuLogin.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMenuLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuLogin.Image")));
            this.btnMenuLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuLogin.Location = new System.Drawing.Point(0, 65);
            this.btnMenuLogin.Name = "btnMenuLogin";
            this.btnMenuLogin.Size = new System.Drawing.Size(170, 42);
            this.btnMenuLogin.TabIndex = 0;
            this.btnMenuLogin.Text = "Login";
            this.btnMenuLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuLogin.UseVisualStyleBackColor = false;
            this.btnMenuLogin.Click += new System.EventHandler(this.btnMenuLogin_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackgroundImage = global::EZAsk.Properties.Resources.imgFundo;
            this.pnlPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(170, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(630, 450);
            this.pnlPrincipal.TabIndex = 6;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 168;
            this.lineShape1.X2 = 0;
            this.lineShape1.Y1 = 53;
            this.lineShape1.Y2 = 53;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(170, 450);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlMenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FrmPrincipal";
            this.Text = "EZAsk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.pnlMenuPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconMenuPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlMenuPrincipal;
        public System.Windows.Forms.Panel pnlPrincipal;
        public System.Windows.Forms.Button btnMenuLogin;
        public System.Windows.Forms.Button btnMenuSobre;
        public System.Windows.Forms.Button btnMenuForum;
        public System.Windows.Forms.Button btnMenuCadastro;
        public System.Windows.Forms.PictureBox IconMenuPrincipal;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}

