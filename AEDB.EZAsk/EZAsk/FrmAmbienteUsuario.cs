using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZAsk;
using EZAsk.Helper;
using EZAsk.Controllers;

namespace EZAsk
{
    public partial class FrmAmbienteUsuario : Form
    {

        FrmPrincipal frmPrincipal = new FrmPrincipal();
        UsuarioLogado _UsLogado = new UsuarioLogado();
        Usuario oUsuario;

        public static string cacheEmailUsuario;
        public static string cacheNomeLogin;
        public static string cacheNomeUsuario;
        public static bool cacheUsuarioAtivo;
        public static int cacheCidade;
        public static string cacheBairro;
        public static int cacheTipoUsuario;
        public static byte[] cacheImgUsuario;
        public static int cacheEstado;
        public static string cacheDataNascimento;

        public FrmAmbienteUsuario()
        {
            InitializeComponent();
            oUsuario = _UsLogado.Selecionar(UsuarioLogado.IdEmailLogado);
        }

        private void FrmAmbienteUsuario_Load(object sender, EventArgs e)
        {
            carregaDados();
        }

        // seta valores nos controles. 
        public void carregaDados()
        {
            lblNickUsuario.Text = oUsuario.NomeLogin;
            imgPerfilUsuario.BackgroundImage = MyGlobal.byteArrayToImage(oUsuario.ImgUsuario);
        }
 
        private void abrirFrmFilho(object formFilho, bool Dock = true)
        {
            if (this.pnlContentUser.Controls.Count > 0)
                this.pnlContentUser.Controls.RemoveAt(0);
            Form frmF = formFilho as Form;
            frmF.TopLevel = false;
            if (Dock)
            {
                frmF.Dock = DockStyle.Fill;
            }
            this.pnlContentUser.Controls.Add(frmF);
            this.pnlContentUser.Tag = frmF;
            frmF.Show();
        }

        // Botões menu.
        private void btnPerfilMenuUser_Click(object sender, EventArgs e)
        {
            abrirFrmFilho(new FrmPerfilUsuario());
        }

        private void btnForumMenuUser_Click(object sender, EventArgs e)
        {
            abrirFrmFilho(new FrmForum());
        }

        private void btnSegurancaMenuUser_Click(object sender, EventArgs e)
        {
            abrirFrmFilho(new FrmSegUsuario());
        }

        private void btnPerguntaMenuUser_Click(object sender, EventArgs e)
        {
            abrirFrmFilho(new FrmPergunta());
        }

        private void btnRespostaMenuUser_Click(object sender, EventArgs e)
        {
            abrirFrmFilho(new FrmResposta());
        }

        private void btnSairMenuUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAmbienteUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desejar sair de sua conta?", "Deslogar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

       
    }
}
