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
    public partial class FrmCadastraUsuario : Form
    {
        public FrmCadastraUsuario()
        {
            InitializeComponent();
        }

        private void FrmCadastraUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmPrincipal)this.MdiParent).menuCadastra.Enabled = true;
        }
    }
}
