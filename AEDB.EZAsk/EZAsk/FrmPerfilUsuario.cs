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
        private FrmAmbienteUsuario frm = new FrmAmbienteUsuario();
        Usuario oUsuario;

        public FrmPerfilUsuario()
        {
            InitializeComponent();
            oUsuario = _UsLogado.Selecionar(new UsuarioLogado().IdEmailLogado);
        }

        private void FrmPerfilUsuario_Load(object sender, EventArgs e)
        {
            comboxPerfilUs();
            carregaDados();
        }
        
        // Comboxs perfil Usuario.
        private void comboxPerfilUs()
        {
            var listaCidades = _UsLogado.SelecionarTodasCidades();
            cboCidade.ValueMember = "id";
            cboCidade.DisplayMember = "nome";
            cboCidade.DataSource = listaCidades;

            var listaEstados = _UsLogado.SelecionarTodosEstados();
            cboEstado.ValueMember = "id";
            cboEstado.DisplayMember = "uf";
            cboEstado.DataSource = listaEstados;

            var listaTipoUs = _UsLogado.SelecionarTodasFormacao();
            cboFormacao.ValueMember = "IDFormacao";
            cboFormacao.DisplayMember = "NomeFormacao";
            cboFormacao.DataSource = listaTipoUs;
        }

        private void carregaDados()
        {
            txtNome.Text = oUsuario.NomeUsuario;

            if (oUsuario.DataNascimento != null)
                dtDataNascimento.Text = oUsuario.DataNascimento;
            else
                dtDataNascimento.Text = null;

            if (oUsuario.Cidade != null)
                cboCidade.SelectedValue = oUsuario.Cidade;
            else
                cboCidade.SelectedValue = "";

            if (oUsuario.Estado != null)
                cboEstado.SelectedValue = oUsuario.Estado;
            else
                cboEstado.SelectedValue = "";

            if (oUsuario.Bairro != null)
                txtBairro.Text = oUsuario.Bairro;
            else
                txtBairro.Text = "";

            if (oUsuario.Formacao != null)
                cboFormacao.SelectedValue = oUsuario.Formacao;
            else
                cboFormacao.SelectedValue = "";

            if (oUsuario.ImgUsuario != null)
                imgPerfilUsuario.BackgroundImage = MyGlobal.byteArrayToImage(oUsuario.ImgUsuario);
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

        // Habilita e desabilita os controles;
        private void habilitaControles(bool enable)
        {
            txtNome.Enabled = enable;
            cboFormacao.Enabled = enable;
            dtDataNascimento.Enabled = enable;
            txtBairro.Enabled = enable;
            cboCidade.Enabled = enable;
            cboEstado.Enabled = enable;
            btnSalvar.Enabled = enable;
            btnUploadImg.Enabled = enable;
            editarPerfil = enable;
        }

        public bool validaControle()
        {
           
            // verifica se os campos estão vazio se estiver retorna false.
            if (txtBairro.Text.Trim() == "" && MyGlobal.ValidarNome(txtBairro.Text))
            {
                MessageBox.Show("Por favor preencha Bairro onde reside!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (txtNome.Text.Trim() == "" && MyGlobal.ValidarNome(txtNome.Text))
            {
                MessageBox.Show("Por favor preencha o seu nome!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (_UsLogado.SelecionarEstado((int)cboEstado.SelectedValue) == null || cboEstado.Text =="")
            {
                MessageBox.Show("Erro ao alterar\nO campo pode estar em branco ou o valor não está registrado no sistema!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (_UsLogado.SelecionarCidade((int)cboCidade.SelectedValue) == null || cboCidade.Text == "")
            {
                MessageBox.Show("Erro ao alterar\nO campo pode estar em branco ou o valor não está registrado no sistema!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (_UsLogado.SelecionarFormacao((int)cboFormacao.SelectedValue) == null || cboFormacao.Text == "")
            {
                MessageBox.Show("Erro ao alterar\nO campo pode estar em branco ou o valor não está registrado no sistema!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else
            {
                return true;
            }
            
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validaControle())
                {
                    oUsuario.NomeUsuario = txtNome.Text;
                    oUsuario.DataNascimento = dtDataNascimento.Text;
                    oUsuario.Formacao = (int)cboFormacao.SelectedValue;
                    oUsuario.Estado = (int) cboEstado.SelectedValue;
                    oUsuario.Cidade = (int) cboCidade.SelectedValue;
                    oUsuario.Bairro = txtBairro.Text;
                    oUsuario.ImgUsuario = MyGlobal.imageToByteArray(imgPerfilUsuario.BackgroundImage);
                    _UsLogado.Alterar(oUsuario);
                    habilitaControles(false);
                    carregaDados();
                    MessageBox.Show("Seu dados foram alterados.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    habilitaControles(false);
                    carregaDados();
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                MessageBox.Show("Alteração Inválida!" + MyGlobal.MsgErro(ex), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alteração Inválido!" + MyGlobal.MsgErro(ex), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                carregaDados();
                habilitaControles(false);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (editarPerfil == false)
            {
                habilitaControles(true);
                btnEditar.Text = "Cancelar";
            }

            else if (editarPerfil == true)
            {
                habilitaControles(false);
                btnEditar.Text = "Editar Perfil";
                carregaDados();
            }
        }
    }
}
