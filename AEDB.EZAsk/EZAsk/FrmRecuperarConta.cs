using EZAsk.Controllers;
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
using System.Net.Mail;
using System.Net;

namespace EZAsk
{
    public partial class FrmRecuperarConta : Form
    {

        private RecuperaConta _Control = new RecuperaConta();
        string msgInf = "Foi enviado um email para seu endereço de email registrado no sistema.\n"+
                        "Por favor verifique a caixa de mensagens.\n"+
                        "Caso não encontre o email na caixa de mensagens verifique no lixo eletrônico.\n"+
                        "\n"+
                        "Depois de encontrar o email abra-o.\n"+
                        "Observe que conterá uma senha gerada do sistema.\n"+
                        "Faça Altenticação novamente com seu email ou nome de usuario e a senha que lhe foi enviada por email.";

        public FrmRecuperarConta()
        {
            InitializeComponent();
        }

        private void FrmRecuperarConta_Load(object sender, EventArgs e)
        {
            txtEmailUsuario.Focus();
        }

        //limpar os campos.
        public void LimpaControles()
        {
            txtEmailUsuario.Text = "";
        }

        public bool validaControle()
        {
            // guarda o valor do usuario e o email se não existe guarda null.
            var email = _Control.getEmail(txtEmailUsuario.Text);

            // verifica se os campos estão vazio se estiver retorna false.

            if (txtEmailUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Por favor preencha o Email!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (MyGlobal.ValidarEmail(txtEmailUsuario.Text) == false)
            {
                MessageBox.Show("Email inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else
            {
                // Validação de Email, se existe no banco retorna boolean = true ou false.

                if (email == null)
                {
                    MessageBox.Show("Email inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmailUsuario.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            if (validaControle())
            {
                pbGifCarregando.Visible = true;
                if (MessageBox.Show("Deseja enviar um e-mail para seu endereço de e-mail registrado no Sistema?", "Confimação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MailMessage mmsg = new MailMessage();
                    
                    string endRemetente = "suporte.ezask@gmail.com";
                    string password = "ezaskaedb";
                    string urlArqHTML = @"..\..\Resources\BodyEmailHTML.txt";

                    string msgSend = System.IO.File.ReadAllText(urlArqHTML);

                    //----------------------------------------------------------------------------
                    //string linha;
                    //MessageBox.Show(Convert.ToString(System.IO.File.ReadLines(urlArqHTML).Count()),"nada");
                    //if (System.IO.File.ReadLines(urlArqHTML).Count() == 36)
                    //{
                    //    // A linha possui a informação que procuro?
                    //    if (linha.Contains("informação"))
                    //    {
                    //        // Sim. Então guarda a informação e abandona o loop
                    //        informacaoQueProcuro = linha;
                    //        break;
                    //    }
                    //}
                    //-----------------------------------------------------------------------------

                    mmsg.To.Add(txtEmailUsuario.Text); // Para quem vou enviar.
                    mmsg.Subject = "Recovery key"; // Assunto email.
                    mmsg.SubjectEncoding = Encoding.UTF8;
                    //mmsg.Bcc.Add(); // Enviar para mais pessoas.

                    mmsg.Body = msgSend; // Conteúdo do email;
                    mmsg.BodyEncoding = Encoding.UTF8; // Codigo do escopo do email.
                    mmsg.IsBodyHtml = true; // Aceita HTML.
                    mmsg.From = new MailAddress(endRemetente); // Quem vai enviar.

                    SmtpClient cliente = new SmtpClient();

                    cliente.Credentials = new NetworkCredential(endRemetente, password);
                    cliente.Port = 587; // Porta padrão.
                    cliente.EnableSsl = true;
                    cliente.Host = "smtp.gmail.com";
                    
                    try
                    {
                        cliente.Send(mmsg);
                        pbGifCarregando.Visible = false;
                        MessageBox.Show("Email foi enviado com Sucesso.\n", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblInfEmailEnviado.Visible = true;
                        lblInfEmailEnviado.Text = msgInf;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Email não foi enviado.\n"+ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        pbGifCarregando.Visible = false;
                    }
                    
                }
                LimpaControles();
            }
        }

        private void txtEmailUsuario_Leave(object sender, EventArgs e)
        {
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
    }
}
