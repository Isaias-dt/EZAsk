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

        public void abrirFrmFilho(object formFilho, bool Dock = true)
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

        // Esconde menu.
        private void IconMenuPrincipal_Click(object sender, EventArgs e)
        {
            if (pnlMenuPrincipal.Width == 170)
            {
                pnlMenuPrincipal.Width = 42;
            }
            else
            {
                pnlMenuPrincipal.Width = 170;
            }
        }
        // Quando passar o mouse por cima execulta o evento hover. 
        private void IconMenuPrincipal_MouseEnter(object sender, EventArgs e)
        {
            IconMenuPrincipal.BackColor = Color.Teal;
        }
        // Desativa o evento hover.
        private void IconMenuPrincipal_MouseLeave(object sender, EventArgs e)
        {
            IconMenuPrincipal.BackColor = Color.Transparent;
        }

        private void btnMenuLogin_Click(object sender, EventArgs e)
        {
            abrirFrmFilho(new FrmLogin());
        }

        public void btnMenuCadastro_Click(object sender, EventArgs e)
        {
            abrirFrmFilho(new FrmCadastraUsuario());
        }

        private void btnMenuForum_Click(object sender, EventArgs e)
        {
            abrirFrmFilho(new FrmForum());
        }

        private void btnMenuSobre_Click(object sender, EventArgs e)
        {
            abrirFrmFilho(new FrmSobreSW());
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        public static void abrirCadUs(object frm)
        {
            new FrmPrincipal().abrirFrmFilho(frm);
        }
        
    }
}
