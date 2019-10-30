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
using EZAsk.DialogBox;

namespace EZAsk
{
    public partial class FrmCadastraUsuario : Form
    {

        private CadastraUsuario _Control = new CadastraUsuario();
        FrmPrincipal frmPrincipal = new FrmPrincipal();

        public FrmCadastraUsuario()
        {
            InitializeComponent();
        }

        //limpar os campos.
        public void LimpaControles()
        {
            txtNomeLogin.Text = "";
            txtNomeUsuario.Text = "";
            txtEmailUsuario.Text = "";
            txtSenhaUsuario.Text = "";
        }
        
        public bool validaControle() 
        {   
            // guarda o valor do usuario e o email se não existe guarda null.

            var email = _Control.getEmail(txtEmailUsuario.Text);
            var nick = _Control.getNick(txtNomeLogin.Text);

            // verifica se os campos estão vazio se estiver retorna false.
            if (txtNomeUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Por favor preencha o Nome!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (txtNomeLogin.Text.Trim() == "")
            {
                MessageBox.Show("Por favor preencha o seu nome Usuario!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (txtEmailUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Por favor preencha o Email!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (txtSenhaUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Por favor digite uma senha!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (MyGlobal.ValidarEmail(txtEmailUsuario.Text) == false)
            { 
                MessageBox.Show("Email inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (MyGlobal.ValidarNome(txtNomeUsuario.Text) == false)
            {
                MessageBox.Show("Nome inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else
            {
                // Validação de Email e nick, se existe no banco não pode cadastrar.

                if (nick != null && email != null)
                {
                    MessageBox.Show("Email e nome de usuário inválidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeLogin.Focus();
                    return false;
                }
                else if (nick != null)
                {
                    MessageBox.Show("Nome de usuário inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeLogin.Focus();
                    return false;
                }
                else if (email != null)
                {
                    MessageBox.Show("Email inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmailUsuario.Focus();
                    return false;
                }
                else
                {
                    DialogBoxConfirmado dialogBoxCConfirmado = new DialogBoxConfirmado();
                    dialogBoxCConfirmado.ShowDialog();
                    txtNomeUsuario.Focus();
                    return true;
                }
            }
        }

        private void btnCadastraUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (validaControle())
                {
                    Usuario oUsuario = new Usuario();

                    oUsuario.NomeUsuario = txtNomeUsuario.Text;
                    oUsuario.NomeLogin = txtNomeLogin.Text;
                    oUsuario.EmailUsuario = txtEmailUsuario.Text;
                    oUsuario.SenhaUsuario = Criptografia.gerarHashMd5(txtSenhaUsuario.Text);
                    oUsuario.UsuarioAtivo = false;
                    _Control.Incluir(oUsuario);
                    LimpaControles();

                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                MessageBox.Show("Impossivel cadastrar! " + MyGlobal.MsgErro(ex), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cadastro Inválido!" + MyGlobal.MsgErro(ex), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmailUsuario_Leave(object sender, EventArgs e)
        {   // Verificando o Email se estár no formato correto.
           
            if (MyGlobal.ValidarEmail(txtEmailUsuario.Text) == false && txtEmailUsuario.Text != "")
            {
                LblInfEmailUsuario.Text = "Digite um Email válido!";
                LblInfEmailUsuario.Visible = true;                    
            }
            else
            {
                LblInfEmailUsuario.Visible = false;
            }
        }

        private void txtNomeUsuario_Leave(object sender, EventArgs e)
        {
            if (MyGlobal.ValidarNome(txtNomeUsuario.Text) == false && txtNomeUsuario.Text != "")
            {
                lblInfNomeUsuario.Text = "Nome inválido por favor apenas Letras!";
                lblInfNomeUsuario.Visible = true;
            }
            else
            {
                lblInfNomeUsuario.Visible = false;
            }
        }

        private void txtNomeLogin_Leave(object sender, EventArgs e)
        {
            if (MyGlobal.ValidarNick(txtNomeLogin.Text) == false && txtNomeLogin.Text != "")
            {
                lblInfNomeLogin.Text = "Nome Usuário inválido! Por favor segue padrão (a-z, A-Z, 0-9 e ., -, _).";
                lblInfNomeLogin.Visible = true;
            }
            else
            {
                lblInfNomeLogin.Visible = false;
            }
        }

        private void txtSenhaUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyGlobal.limitarDigitoSenha(e);
        }
    }
}
