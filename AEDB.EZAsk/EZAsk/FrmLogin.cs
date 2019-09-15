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
using EZAsk.Repository;


namespace EZAsk
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmPrincipal)this.MdiParent).menuLogin.Enabled = true;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

           
        }

        // verifica se os campos estão vazio se estiver retorna false se não retorno true.
        public bool validaControle()
        {
            if (txtAltUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Digite o email ou nome de usuario para se conectar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            else if (txtAltSenha.Text.Trim() == "")
            {
                MessageBox.Show("Digite o senha para se conectar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            else
            {
                return true;
            }
        }

        public bool validaUsuario(string usuario)
        {

            return false;
        }

        private void imgLoginPadrao_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCadastreSe_Click(object sender, EventArgs e)
        {
            FrmCadastraUsuario frmCadUsuario = new FrmCadastraUsuario();
            FrmPrincipal frmPrincipal = new FrmPrincipal();

            frmCadUsuario.Show();
            ((FrmPrincipal)this.MdiParent).menuCadastra.Enabled = false;
            this.Close();
         
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtAltUsuario_Leave(object sender, EventArgs e)
        {
            RepositoryUsuario _acha = new RepositoryUsuario();

            if (_acha.AchaUsuario(txtAltUsuario.Text))
            {
                MessageBox.Show("Usuario existe");
            }
            else
            {
                MessageBox.Show("Usuario não existe");
            }
        }
    }
}
