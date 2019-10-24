using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZAsk;
using EZAsk.Helper;

namespace EZAsk
{
    public partial class FrmAmbienteUsuario : Form
    {

        FrmPrincipal frmPrincipal = new FrmPrincipal();
        public FrmAmbienteUsuario()
        {
            InitializeComponent();
        }

        private void FrmAmbienteUsuario_Load(object sender, EventArgs e)
        {
            this.Parent = frmPrincipal.pnlPrincipal;
        }

        private void abrirFrmFilho(object formFilho, bool Dock = true)
        {
            if (this.pnlContentUser.Controls.Count > 0)
                this.pnlContentUser.Controls.RemoveAt(0);
            Form frmF = formFilho as Form;
            frmF.TopLevel = false;
            if (Dock)
            {
                frmF.Dock = DockStyle.Fill;
            }
            this.pnlContentUser.Controls.Add(frmF);
            this.pnlContentUser.Tag = frmF;
            frmF.Show();
        }

        private void btnPerfilMenuUser_Click(object sender, EventArgs e)
        {
            abrirFrmFilho(new FrmPerfilUsuario());
        }

        private void btnForumMenuUser_Click(object sender, EventArgs e)
        {
            abrirFrmFilho(new FrmForum());
        }

        private void btnSegurancaMenuUser_Click(object sender, EventArgs e)
        {
            abrirFrmFilho(new FrmSegUsuario());
        }

        private void btnSairMenuUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAmbienteUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desejar sair de sua conta?", "Deslogar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
