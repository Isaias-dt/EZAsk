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
            ((FrmPrincipal)this.MdiParent).menuFrmPrincipal.Visible = false;
            this.WindowState = FormWindowState.Maximized;

        }
    }
}
