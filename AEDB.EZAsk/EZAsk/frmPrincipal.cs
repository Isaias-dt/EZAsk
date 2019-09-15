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
        public FrmPrincipal()
        {
            InitializeComponent();
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
            menuLogin.Enabled = false;
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.MdiParent = this;
            frmLogin.Show();
        }

        private void menuForum_Click(object sender, EventArgs e)
        {
            menuForum.Enabled = false;
            FrmForum frmForum = new FrmForum();
            frmForum.MdiParent = this;
            frmForum.Show();
            //frmForum.WindowState = FormWindowState.Maximized;
            
        }

        private void menuSobre_Click(object sender, EventArgs e)
        {
            menuSobre.Enabled = false;
            FrmSobre frmSobre = new FrmSobre();
            frmSobre.MdiParent = this;
            frmSobre.Show();
        }
    }
}
