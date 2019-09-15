using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZAsk.Helper;

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
            ((FrmPrincipal)this.MdiParent).menuForum.Enabled = true;
        }

        private void FrmForum_Load(object sender, EventArgs e)
        {   
            this.WindowState = FormWindowState.Maximized; // maximinizando a form Forum dentro do conteiner principal.
        }
    }
}
