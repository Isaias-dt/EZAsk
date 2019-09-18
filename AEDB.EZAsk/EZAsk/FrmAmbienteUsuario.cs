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
            
            // Sintaxe errada.
            //((FrmPrincipal)this.MdiParent).menuFrmPrincipal.Visible = false;
            this.WindowState = FormWindowState.Maximized;
            frmPrincipal.menuCadastra.Visible = false;
        }

        private void btnDeslogarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAmbienteUsuario_Activated(object sender, EventArgs e)
        {
            frmPrincipal.menuCadastra.Visible = false;
            frmPrincipal.menuLogin.Visible = false;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
