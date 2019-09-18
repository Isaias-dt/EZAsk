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
            ((System.ComponentModel.ISupportInitialize)(this.grdForum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Location = new System.Drawing.Point(675, 78);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(106, 27);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisar.Location = new System.Drawing.Point(290, 82);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(379, 20);
            this.txtPesquisar.TabIndex = 2;
            // 
            // grdForum
            // 
            this.grdForum.AllowUserToAddRows = false;
            this.grdForum.AllowUserToDeleteRows = false;
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
            this.grdForum.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdForum.GridColor = System.Drawing.SystemColors.Control;
            this.grdForum.Location = new System.Drawing.Point(0, 108);
            this.grdForum.MultiSelect = false;
            this.grdForum.Name = "grdForum";
            this.grdForum.ReadOnly = true;
            this.grdForum.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdForum.RowHeadersVisible = false;
            this.grdForum.Size = new System.Drawing.Size(781, 365);
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
            // FrmForum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(781, 473);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.grdForum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmForum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forum EZAsk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmForum_FormClosed);
            this.Load += new System.EventHandler(this.FrmForum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdForum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}