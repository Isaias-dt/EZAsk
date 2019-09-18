namespace EZAsk
{
    partial class FrmResponder
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
            this.txtAreaBoxResposta = new System.Windows.Forms.RichTextBox();
            this.btnEnviarResposta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAreaBoxResposta
            // 
            this.txtAreaBoxResposta.Location = new System.Drawing.Point(12, 93);
            this.txtAreaBoxResposta.Name = "txtAreaBoxResposta";
            this.txtAreaBoxResposta.Size = new System.Drawing.Size(391, 190);
            this.txtAreaBoxResposta.TabIndex = 0;
            this.txtAreaBoxResposta.Text = "";
            // 
            // btnEnviarResposta
            // 
            this.btnEnviarResposta.Location = new System.Drawing.Point(300, 289);
            this.btnEnviarResposta.Name = "btnEnviarResposta";
            this.btnEnviarResposta.Size = new System.Drawing.Size(103, 38);
            this.btnEnviarResposta.TabIndex = 1;
            this.btnEnviarResposta.Text = "Enviar";
            this.btnEnviarResposta.UseVisualStyleBackColor = true;
            // 
            // FrmResponder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 339);
            this.Controls.Add(this.btnEnviarResposta);
            this.Controls.Add(this.txtAreaBoxResposta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmResponder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Responder Dúvida";
            this.Load += new System.EventHandler(this.FrmResponder_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtAreaBoxResposta;
        private System.Windows.Forms.Button btnEnviarResposta;
    }
}