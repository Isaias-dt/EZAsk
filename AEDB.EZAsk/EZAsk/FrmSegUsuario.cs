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
using EZAsk.Controllers;

namespace EZAsk
{
    public partial class FrmSegUsuario : Form
    {
        UsuarioLogado _UsLogado = new UsuarioLogado();
        Usuario oUsuario;

        public FrmSegUsuario()
        {
            InitializeComponent();
            oUsuario = _UsLogado.Selecionar(new UsuarioLogado().IdEmailLogado);
            habilitaControles_TabAlterSenha();
            
        }

        private void FrmSegUsuario_Load(object sender, EventArgs e)
        {
            txtEmailAtual.Text = oUsuario.EmailUsuario;
            txtNomeLoginAtual.Text = oUsuario.NomeLogin;
        }

        /*********** CODIGO TAB REDEFINIR SENHA ***********/

        // Habilita e desabilita os controles.
        private void habilitaControles_TabAlterSenha(bool enable = false)
        {
            txtNovaSenha1.Enabled = enable;
            txtNovaSenha2.Enabled = enable;
            btnAlterarSenha.Enabled = enable;
        }

        public void limpaControles_TabAlterSenha()
        {
            txtSenhaAtual.Text = "";
            txtNovaSenha1.Text = "";
            txtNovaSenha2.Text = "";
        }

        // Valida os controles.
        public bool ValidaControles_TabAlterSenha()
        {
            if (txtSenhaAtual.Text.Trim() == "")
            {
                MessageBox.Show("Por favor digite uma senha!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (txtNovaSenha1.Text.Trim() == "" || txtNovaSenha2.Text.Trim() == "")
            {
                MessageBox.Show("Por favor preencha o campo nova senha!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (!txtNovaSenha1.Text.Equals(txtNovaSenha2.Text))
            {
                MessageBox.Show("incompatibilidade dos valores dos campos nova senha!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else
            {
                return true;
            }
        }

        // Botão altera senha.
        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            try { 

                if (ValidaControles_TabAlterSenha())
                {
                    if (MessageBox.Show("Deseja mesmo redefinir a senha?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        oUsuario.SenhaUsuario = Criptografia.gerarHashMd5(txtNovaSenha2.Text);
                        _UsLogado.Alterar(oUsuario);
                        habilitaControles_TabAlterSenha(false);
                        limpaControles_TabAlterSenha();
                        btnConferirSenha.Enabled = true;
                        txtSenhaAtual.Enabled = true;

                        MessageBox.Show("A senha foi alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        habilitaControles_TabAlterSenha(false);
                        limpaControles_TabAlterSenha();
                        btnConferirSenha.Enabled = true;
                        txtSenhaAtual.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel Alterar a senha.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNovaSenha1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyGlobal.limitarDigitoSenha(e);
        }

        private void txtNovaSenha2_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyGlobal.limitarDigitoSenha(e);
        }

        // Botão conferir a senha atual do usuario para fazer a alteração. 
        private void btnConferirSenha_Click(object sender, EventArgs e)
        {
            if (_UsLogado.AutenticaUsuario(oUsuario.EmailUsuario, txtSenhaAtual.Text) != null)
            {
                habilitaControles_TabAlterSenha(true);
                btnConferirSenha.Enabled = false;
                txtSenhaAtual.Enabled = false;
            }
            else
            {
                MessageBox.Show("Senha inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Botão cancelar Alteração de senha.
        private void btnCancelAlterSenha_Click(object sender, EventArgs e)
        {
            habilitaControles_TabAlterSenha(false);
            limpaControles_TabAlterSenha();
            btnConferirSenha.Enabled = true;
            txtSenhaAtual.Enabled = true;
            CBMostrarSenha.CheckState = CheckState.Unchecked;

        }

        // Mostra a senha que o usuário está digitando.
        private void CBMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (CBMostrarSenha.Checked)
            {
                txtNovaSenha1.PasswordChar = '\0';
                txtNovaSenha2.PasswordChar = '\0';
               
            }
            else
            {
                txtNovaSenha1.PasswordChar = '●';
                txtNovaSenha2.PasswordChar = '●';
            }
        }

        /*********** CODIGO TAB REDEFINIR EMAIL ***********/

        public void limpaControles_TabAlterEmail()
        {
            txtNovoEmail.Text = "";
            txtSenhaUsuario_tabAlterEmail.Text = "";
        }

        // Valida os controles do tab alterar email.
        public bool ValidaControles_TabAlterEmail()
        {
            if (txtNovoEmail.Text.Trim() == "" || !MyGlobal.ValidarEmail(txtNovoEmail.Text))
            {
                MessageBox.Show("Por favor digite um Email válido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (txtSenhaUsuario_tabAlterEmail.Text.Trim() == "")
            {
                MessageBox.Show("Por favor digite sua senha para válidar a alteração!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (_UsLogado.Selecionar(txtNovoEmail.Text) != null)
            {
                MessageBox.Show("Esse email já está cadastrado no sistema!", "Email inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else
            {
                return true;
            }
        }

        // Botão Alterar Email.
        private void btnAlterarEmail_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaControles_TabAlterEmail())
                {
                    if (_UsLogado.AutenticaUsuario(oUsuario.EmailUsuario, txtSenhaUsuario_tabAlterEmail.Text) != null)
                    {
                        if (MessageBox.Show("Deseja mesmo redefinir o email?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            oUsuario.EmailUsuario = txtNovoEmail.Text;
                            _UsLogado.Alterar(oUsuario);
                            limpaControles_TabAlterEmail();

                            MessageBox.Show("A email foi alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            limpaControles_TabAlterEmail();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Senha inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel Alterar o Email.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Botão cancelar alteração 
        private void btnCancelAlterEmail_Click(object sender, EventArgs e)
        {
            limpaControles_TabAlterEmail();
        }

        /*********** CODIGO TAB REDEFINIR NOME LOGIN(NICK) ***********/

        public void limpaControles_TabAlterNick()
        {
            txtNovoNomeLogin.Text = "";
            txtSenhaUsuario_tabAlterLogin.Text = "";
        }

        // Valida os controles do tab alterar login.
        public bool ValidaControles_TabAlterNick()
        {
            if (txtNovoNomeLogin.Text.Trim() == "" || !MyGlobal.ValidarNick(txtNovoNomeLogin.Text))
            {
                MessageBox.Show("Por favor digite um nome de login válido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (txtSenhaUsuario_tabAlterLogin.Text.Trim() == "")
            {
                MessageBox.Show("Por favor digite sua senha para válidar a alteração!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (_UsLogado.getNick(txtNovoNomeLogin.Text) != null)
            {
                MessageBox.Show("Esse nome login já está cadastrado no sistema!", "login inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else
            {
                return true;
            }
        }

        // Botão Alterar login.
        private void btnAlterarNomeLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaControles_TabAlterNick())
                {
                    if (_UsLogado.AutenticaUsuario(oUsuario.NomeLogin, txtSenhaUsuario_tabAlterLogin.Text) != null)
                    {
                        if (MessageBox.Show("Deseja mesmo redefinir o nome de login?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            oUsuario.NomeLogin = txtNovoNomeLogin.Text;
                            _UsLogado.Alterar(oUsuario);
                            limpaControles_TabAlterNick();

                            MessageBox.Show("A nome de login foi alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            limpaControles_TabAlterNick();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Senha inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel Alterar o Email.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Botão cancelar alteração login.
        private void btnCancelAlterLogin_Click(object sender, EventArgs e)
        {
            limpaControles_TabAlterNick();
        }

        // Ocorre quando a página(tab) é mudada.
        private void tbcSeguranca_Selecting(object sender, TabControlCancelEventArgs e)
        {
            limpaControles_TabAlterSenha();
            btnConferirSenha.Enabled = true;
            txtSenhaAtual.Enabled = true;
            habilitaControles_TabAlterSenha(false);

            limpaControles_TabAlterEmail();

            limpaControles_TabAlterNick();
        }
    }
}
