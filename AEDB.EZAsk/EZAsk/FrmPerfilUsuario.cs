using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZAsk.Controllers;
using EZAsk.Helper;

namespace EZAsk
{
    public partial class FrmPerfilUsuario : Form
    {

        private bool editarPerfil = false;
        private UsuarioLogado _UsLogado = new UsuarioLogado();

        public FrmPerfilUsuario()
        {
            InitializeComponent();
        }

        private void FrmPerfilUsuario_Load(object sender, EventArgs e)
        {
            var listaCidades = _UsLogado.SelecionarTodasCidades();
            cboCidade.ValueMember = "id";
            cboCidade.DisplayMember = "nome";
            cboCidade.DataSource = listaCidades;

            var listaEstados = _UsLogado.SelecionarTodosEstados();
            cboEstado.ValueMember = "id";
            cboEstado.DisplayMember = "uf";
            cboEstado.DataSource = listaEstados;

            var listaTipoUs = _UsLogado.SelecionarTodosTipoUs();
            cboTipoUsuario.ValueMember = "IDTipoUsuario";
            cboTipoUsuario.DisplayMember = "NomeTipoUsuario";
            cboTipoUsuario.DataSource = listaTipoUs;
        }

        private void btnUploadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Arquivos de imagem(*.bmp, *.jpg, *.png) | *.bmp; *.jpg; *.png"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgPerfilUsuario.BackgroundImage = null;
                imgPerfilUsuario.BackgroundImage = System.Drawing.Image.FromFile(ofd.FileName);
            }
        }

        public bool validaControle()
        {
            // guarda o valor do usuario e o email se não existe guarda null.

            var email = _UsLogado.getEmail(txtNome.Text);
            var nick = _UsLogado.getNick(txtSobrenome.Text);

            // verifica se os campos estão vazio se estiver retorna false.
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Por favor preencha o Nome!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Por favor preencha o seu nome Usuario!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (txtSobrenome.Text.Trim() == "")
            {
                MessageBox.Show("Por favor preencha o Email!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
 
            return false;
        }

        private void habilitaControles(bool enable)
        {
            txtNome.Enabled = enable;
            txtSobrenome.Enabled = enable;
            cboTipoUsuario.Enabled = enable;
            dtDataNascimento.Enabled = enable;
            txtBairro.Enabled = enable;
            cboCidade.Enabled = enable;
            cboEstado.Enabled = enable;
            btnSalvar.Enabled = enable;
            btnUploadImg.Enabled = enable;
            editarPerfil = enable;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validaControle() == true && editarPerfil == false)
            {
                try
                {
                    if (validaControle())
                    {
                        Usuario oUsuario = new Usuario();

                        oUsuario.NomeUsuario = txtNome.Text;
                        oUsuario.NomeLogin = txtSobrenome.Text;
                        oUsuario.DataNascimento = dtDataNascimento.Text;
                        //oUsuario.TipoUsuario = txtTipoUsuario.Text;
                        //oUsuario.Estado = dtDataNascimento.Text;
                        //oUsuario.Cidade = dtDataNascimento.Text;
                        //oUsuario.Bairro = dtDataNascimento.Text;
                        oUsuario.ImgUsuario = MyGlobal.imageToByteArray(imgPerfilUsuario.BackgroundImage);

                        _UsLogado.Incluir(oUsuario);
                        attDadosCampo();

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
        }

        //limpar os campos.
        public void attDadosCampo()
        {
            
        }

        private void habilitaControles()
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (editarPerfil == false)
            {
                txtNome.Enabled = true;
                txtSobrenome.Enabled = true;
                cboTipoUsuario.Enabled = true;
                dtDataNascimento.Enabled = true;
                txtBairro.Enabled = true;
                cboCidade.Enabled = true;
                cboEstado.Enabled = true;
                btnSalvar.Enabled = true;
                btnUploadImg.Enabled = true;
                editarPerfil = true;
                btnEditar.Text = "Cancelar";
                
            }

            else if (editarPerfil == true)
            {
                txtNome.Enabled = false;
                txtSobrenome.Enabled = false;
                cboTipoUsuario.Enabled = false;
                dtDataNascimento.Enabled = false;
                txtBairro.Enabled = false;
                cboCidade.Enabled = false;
                cboEstado.Enabled = false;
                btnSalvar.Enabled = false;
                btnUploadImg.Enabled = false;
                editarPerfil = false;
                btnEditar.Text = "Editar Perfil";
            }
        }

        
    }
}
