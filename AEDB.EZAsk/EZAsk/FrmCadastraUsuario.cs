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
    public partial class FrmCadastraUsuario : Form
    {

        private CadastraUsuario _Control = new CadastraUsuario();

        public FrmCadastraUsuario()
        {
            InitializeComponent();
        }

        private void FrmCadastraUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmPrincipal)this.MdiParent).menuCadastra.Enabled = true;
        }

        private void FrmCadastraUsuario_Load(object sender, EventArgs e)
        {
           
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
                MessageBox.Show("Por favor preencha o Nome!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            else if (txtNomeLogin.Text.Trim() == "")
            {
                MessageBox.Show("Por favor preencha o seu nome Usuario!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            else if (txtEmailUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Por favor preencha o Email!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            else if (txtSenhaUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Por favor digite uma senha!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
       
            else
            {
                // Validação de Email e nick, se existe no banco não pode cadastrar.

                if (nick != null && email != null)
                {
                    MessageBox.Show("Email e nick ja existe");
                    txtNomeLogin.Focus();
                    return false;
                }
                else if (nick != null)
                {
                    MessageBox.Show("Esse nick já existe!.");
                    txtNomeLogin.Focus();
                    return false;
                }
                else if (email != null)
                {
                    MessageBox.Show("Esse Email ja existe.");
                    txtEmailUsuario.Focus();
                    return false;
                }
                else
                {
                    MessageBox.Show("Cadastro efetuado com sucesso!");
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
        {   // Verificando Email se estar no formato correto.
            while (true)
            {
                if (MyGlobal.ValidarEmail(txtEmailUsuario.Text) == false)
                {
                    infLabelEmail.Text = "Digite um Email válido.";
                    break;
                }
                else
                {
                    infLabelEmail.Visible = false;
                }
            }
            
        }
    }
}
