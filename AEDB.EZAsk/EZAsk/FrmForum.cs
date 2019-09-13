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
    public partial class FrmForum : Form
    {
        public FrmForum()
        {
            InitializeComponent();
        }

        private void FrmForum_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmPrincipal)this.MdiParent).menuForum.Enabled = true;
        }
    }
}
