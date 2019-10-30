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
            oUsuario = _UsLogado.Selecionar(UsuarioLogado.IdEmailLogado);
            habilitaControles();
        }

        private void FrmSegUsuario_Load(object sender, EventArgs e)
        {

        }

        // Habilita e desabilita os controles;
        private void habilitaControles(bool enable = false)
        {
            txtNovaSenha1.Enabled = enable;
            txtNovaSenha2.Enabled = enable;
            btnAlterarSenha.Enabled = enable;
        }

        public bool ValidaControles()
        {
            if (txtSenhaUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Por favor digite uma senha!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (txtNovaSenha1.Text.Trim() == "" || txtNovaSenha2.Text.Trim() == "")
            {
                MessageBox.Show("Por favor preencha o campo nova senha!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (_UsLogado.AutenticaUsuario(UsuarioLogado.idEmailLogado, txtSenhaAtual.Text) == null)
            {
                MessageBox.Show("Senha não confere.\nTende novamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (!txtNovaSenha1.Text.Equals(txtNovaSenha2))
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                try
                {
                    oUsuario.SenhaUsuario = Criptografia.gerarHashMd5(txtNovaSenha2.Text);
                    _UsLogado.Alterar(oUsuario);
               
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel trocar a senha\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
    }
}
