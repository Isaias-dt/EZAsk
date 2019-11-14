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
using EZAsk.Controllers;


namespace EZAsk
{
    public partial class FrmLogin : Form
    {
        Login _Us = new Login();
        int qtsTentativaLogin = 0;
        FrmPrincipal frmPrincipal = new FrmPrincipal();
        Usuario oUsuario;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtAltUsuario.Focus();
        }

        //limpar os campos.
        public void LimpaControles()
        {
            txtAltUsuario.Text = "";
            txtAltSenha.Text = "";
        }

        // verifica se os campos estão vazio se estiver retorna false se não retorno true.
        public bool validaControle()
        {

            if (txtAltUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Digite o email ou nome de usuario para se conectar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (txtAltSenha.Text.Trim() == "")
            {
                MessageBox.Show("Digite o senha para se conectar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else
            {
                return true;
            }
        }

        // Botão Cadastrar da tela login.
        private void btnCadastreSe_Click(object sender, EventArgs e)
        {            
            frmPrincipal.btnMenuCadastro.PerformClick();
            frmPrincipal.btnMenuCadastro_Click(null, null);
        }

        // Botão Entrar no ambiente usuário.
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validaControle())
                {   // Variavel recebe null se o nick e senha não for igual. 
                    
                    var bdUsuario = _Us.AutenticaUsuario(txtAltUsuario.Text, txtAltSenha.Text);
                    

                    if (bdUsuario == null)
                    {
                        // Quando não for autenticado.
                        MessageBox.Show("Senha ou Email inválidos!", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpaControles();
                        txtAltUsuario.Focus();
                        qtsTentativaLogin++;
                        if(qtsTentativaLogin == 3)
                        {
                            lblTrocarSenha.Visible = true;
                        }
                    }
                    else
                    {
                        if (!(bool)bdUsuario.UsuarioAtivo)
                        {
                            // Quando for autenticado.

                            new UsuarioLogado().IdEmailLogado = bdUsuario.EmailUsuario; // Envia o id para UsuarioLogado.
                            LimpaControles();
                            //frmPrincipal.abrirFrmFilho(new FrmAmbienteUsuario());
                            new FrmAmbienteUsuario().Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario já esta logado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            LimpaControles();
                            txtAltUsuario.Focus();
                        }

                    }
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                MessageBox.Show(MyGlobal.MsgErro(ex), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblTrocarSenha_MouseEnter(object sender, EventArgs e)
        {
            lblTrocarSenha.BorderStyle = BorderStyle.FixedSingle;
        }

        private void lblTrocarSenha_MouseLeave(object sender, EventArgs e)
        {
            lblTrocarSenha.BorderStyle = BorderStyle.None;
        }
    }
}
