namespace EZAsk
{
    partial class FrmPergunta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPergunta));
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.txtAreaPergunta = new System.Windows.Forms.RichTextBox();
            this.btnEnviarPergunta = new System.Windows.Forms.Button();
            this.btnFonte = new System.Windows.Forms.Button();
            this.btnAnexarImg = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tire suas dúvidas:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAreaPergunta
            // 
            this.txtAreaPergunta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAreaPergunta.Location = new System.Drawing.Point(32, 119);
            this.txtAreaPergunta.Name = "txtAreaPergunta";
            this.txtAreaPergunta.Size = new System.Drawing.Size(744, 118);
            this.txtAreaPergunta.TabIndex = 2;
            this.txtAreaPergunta.Text = "";
            // 
            // btnEnviarPergunta
            // 
            this.btnEnviarPergunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEnviarPergunta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarPergunta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEnviarPergunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarPergunta.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarPergunta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEnviarPergunta.Location = new System.Drawing.Point(32, 243);
            this.btnEnviarPergunta.Name = "btnEnviarPergunta";
            this.btnEnviarPergunta.Size = new System.Drawing.Size(118, 32);
            this.btnEnviarPergunta.TabIndex = 8;
            this.btnEnviarPergunta.Text = "Enviar";
            this.btnEnviarPergunta.UseVisualStyleBackColor = false;
            this.btnEnviarPergunta.Click += new System.EventHandler(this.btnEnviarPergunta_Click);
            // 
            // btnFonte
            // 
            this.btnFonte.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFonte.Location = new System.Drawing.Point(32, 87);
            this.btnFonte.Name = "btnFonte";
            this.btnFonte.Size = new System.Drawing.Size(32, 26);
            this.btnFonte.TabIndex = 9;
            this.btnFonte.Text = "F";
            this.btnFonte.UseVisualStyleBackColor = true;
            // 
            // btnAnexarImg
            // 
            this.btnAnexarImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnexarImg.BackgroundImage")));
            this.btnAnexarImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnexarImg.Location = new System.Drawing.Point(70, 87);
            this.btnAnexarImg.Name = "btnAnexarImg";
            this.btnAnexarImg.Size = new System.Drawing.Size(32, 26);
            this.btnAnexarImg.TabIndex = 9;
            this.btnAnexarImg.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(29, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 254);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suas dúvidas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 235);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulo:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(90, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(686, 26);
            this.txtNome.TabIndex = 11;
            // 
            // FrmPergunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAnexarImg);
            this.Controls.Add(this.btnFonte);
            this.Controls.Add(this.btnEnviarPergunta);
            this.Controls.Add(this.txtAreaPergunta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPergunta";
            this.Text = "FrmPergunta";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.RichTextBox txtAreaPergunta;
        private System.Windows.Forms.Button btnEnviarPergunta;
        private System.Windows.Forms.Button btnFonte;
        private System.Windows.Forms.Button btnAnexarImg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
    }
}