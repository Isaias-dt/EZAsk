namespace EZAsk
{
    partial class FrmForum
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.grdForum = new System.Windows.Forms.DataGridView();
            this.UsuarioPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MateriaPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TituloPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnResponder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlHeaderForum = new System.Windows.Forms.Panel();
            this.pnlBodyForum = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grdForum)).BeginInit();
            this.pnlHeaderForum.SuspendLayout();
            this.pnlBodyForum.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Location = new System.Drawing.Point(663, 67);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(106, 27);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisar.Location = new System.Drawing.Point(278, 71);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(379, 20);
            this.txtPesquisar.TabIndex = 2;
            // 
            // grdForum
            // 
            this.grdForum.AllowUserToAddRows = false;
            this.grdForum.AllowUserToDeleteRows = false;
            this.grdForum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdForum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdForum.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdForum.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdForum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdForum.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.grdForum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdForum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsuarioPost,
            this.MateriaPost,
            this.TituloPost,
            this.Post,
            this.btnResponder});
            this.grdForum.GridColor = System.Drawing.SystemColors.Control;
            this.grdForum.Location = new System.Drawing.Point(0, 0);
            this.grdForum.MultiSelect = false;
            this.grdForum.Name = "grdForum";
            this.grdForum.ReadOnly = true;
            this.grdForum.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdForum.RowHeadersVisible = false;
            this.grdForum.Size = new System.Drawing.Size(781, 376);
            this.grdForum.StandardTab = true;
            this.grdForum.TabIndex = 0;
            this.grdForum.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdForum_CellClick);
            // 
            // UsuarioPost
            // 
            this.UsuarioPost.HeaderText = "Nome";
            this.UsuarioPost.Name = "UsuarioPost";
            this.UsuarioPost.ReadOnly = true;
            // 
            // MateriaPost
            // 
            this.MateriaPost.HeaderText = "Matéria";
            this.MateriaPost.Name = "MateriaPost";
            this.MateriaPost.ReadOnly = true;
            // 
            // TituloPost
            // 
            this.TituloPost.HeaderText = "Titulo";
            this.TituloPost.Name = "TituloPost";
            this.TituloPost.ReadOnly = true;
            // 
            // Post
            // 
            this.Post.HeaderText = "Pergunta";
            this.Post.Name = "Post";
            this.Post.ReadOnly = true;
            // 
            // btnResponder
            // 
            this.btnResponder.HeaderText = "Responder";
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.ReadOnly = true;
            // 
            // pnlHeaderForum
            // 
            this.pnlHeaderForum.Controls.Add(this.btnPesquisar);
            this.pnlHeaderForum.Controls.Add(this.txtPesquisar);
            this.pnlHeaderForum.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderForum.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderForum.Name = "pnlHeaderForum";
            this.pnlHeaderForum.Size = new System.Drawing.Size(781, 97);
            this.pnlHeaderForum.TabIndex = 3;
            // 
            // pnlBodyForum
            // 
            this.pnlBodyForum.Controls.Add(this.grdForum);
            this.pnlBodyForum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBodyForum.Location = new System.Drawing.Point(0, 97);
            this.pnlBodyForum.Name = "pnlBodyForum";
            this.pnlBodyForum.Size = new System.Drawing.Size(781, 376);
            this.pnlBodyForum.TabIndex = 3;
            // 
            // FrmForum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(781, 473);
            this.Controls.Add(this.pnlBodyForum);
            this.Controls.Add(this.pnlHeaderForum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmForum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forum EZAsk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmForum_FormClosed);
            this.Load += new System.EventHandler(this.FrmForum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdForum)).EndInit();
            this.pnlHeaderForum.ResumeLayout(false);
            this.pnlHeaderForum.PerformLayout();
            this.pnlBodyForum.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView grdForum;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn TituloPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Post;
        private System.Windows.Forms.DataGridViewButtonColumn btnResponder;
        private System.Windows.Forms.Panel pnlHeaderForum;
        private System.Windows.Forms.Panel pnlBodyForum;
    }
}