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
        Form _objFrm;

        FrmPrincipal frmPrincipal = new FrmPrincipal();
        public FrmAmbienteUsuario()
        {
            InitializeComponent();
        }

        private void FrmAmbienteUsuario_Load(object sender, EventArgs e)
        {
            // Sintaxe errada.
            //((FrmPrincipal)this.MdiParent).menuFrmPrincipal.Visible = false;
            //this.WindowState = FormWindowState.Maximized;
            //frmPrincipal.menuCadastra.Visible = false;

        }

        private void FrmAmbienteUsuario_Activated(object sender, EventArgs e)
        {
            frmPrincipal.menuCadastra.Visible = false;
            frmPrincipal.menuLogin.Visible = false;
            
        }

        private void btnPerfilMenuUser_Click(object sender, EventArgs e)
        {
            _objFrm?.Close();
            _objFrm = new FrmPerfilUsuario
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill  
            };
            pnlContentUser.Controls.Add(_objFrm);
            _objFrm.Show();
        }

        private void btnForumMenuUser_Click(object sender, EventArgs e)
        {
            _objFrm?.Close();
            _objFrm = new FrmForum
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlContentUser.Controls.Add(_objFrm);
            _objFrm.Show();
        }
    }
}
