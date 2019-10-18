using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZAsk
{
    public partial class FrmPrincipal : Form
    {
        private Form _objFrm;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void abrirFrmFilho(object formFilho, bool Dock = true)
        {
            if (this.pnlPrincipal.Controls.Count > 0)
                this.pnlPrincipal.Controls.RemoveAt(0);
            Form frmF = formFilho as Form;
            frmF.TopLevel = false;
            if (Dock)
            {
                frmF.Dock = DockStyle.Fill;
            }
            this.pnlPrincipal.Controls.Add(frmF);
            this.pnlPrincipal.Tag = frmF;
            frmF.Show();
        }

        //Na propriedade deste form foi setado "isMdiConteiner = true", para virar um conteiner dos outros forms.
        private void menuCadastra_Click(object sender, EventArgs e)
        {
            menuCadastra.Enabled = false;
            FrmCadastraUsuario frmCadUsuario = new FrmCadastraUsuario();
            frmCadUsuario.MdiParent = this;
            frmCadUsuario.Show();
        }

        private void menuLogin_Click(object sender, EventArgs e)
        {
            //menuLogin.Enabled = false;
            //FrmLogin frmLogin = new FrmLogin();
            //frmLogin.MdiParent = this;
            //frmLogin.Show();

            //_objFrm?.Close();
            //_objFrm = new FrmLogin
            //{
            //    TopLevel = false
            //};
            //pnlPrincipal.Controls.Add(_objFrm);
            //_objFrm.Show();

            abrirFrmFilho(new FrmLogin(), false);
        }

        private void menuForum_Click(object sender, EventArgs e)
        {
            menuForum.Enabled = false;
            FrmForum frmForum = new FrmForum();
            frmForum.MdiParent = this;
            frmForum.Show();

            abrirFrmFilho(frmForum);
        }

        private void menuSobre_Click(object sender, EventArgs e)
        {
            menuSobre.Enabled = false;
            FrmSobreSW frmSobreSW = new FrmSobreSW();
            frmSobreSW.MdiParent = this;
            frmSobreSW.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void pnlPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
