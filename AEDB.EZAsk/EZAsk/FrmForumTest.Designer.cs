namespace EZAsk
{
    partial class FrmForumTest
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
            this.webBForum = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBForum
            // 
            this.webBForum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBForum.Location = new System.Drawing.Point(0, 0);
            this.webBForum.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBForum.Name = "webBForum";
            this.webBForum.Size = new System.Drawing.Size(800, 450);
            this.webBForum.TabIndex = 0;
            this.webBForum.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // FrmForumTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBForum);
            this.Name = "FrmForumTest";
            this.Text = "FrmForumTest";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBForum;
    }
}