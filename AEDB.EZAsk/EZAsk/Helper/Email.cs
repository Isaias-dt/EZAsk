using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZAsk.Helper
{
    class Email
    {
        private bool envioOK;                 // Define o estado atual de envio do email
        private string emailDestinatario;  // email que receberá a mensagem
        private string assunto;                 // assunto da mensagem 
        private string mensagem;            // mensagem do email

        //Aqui deve ser os dados da sua conta de email
        private string emailAdm;        // Conta de email válida
        private string servidor;           // Servidor da conta de email
        private string senha;              // Define a senha da conta de email valida

        MailMessage email = new MailMessage();

        /// <summary>
        /// Construtora da Classe. 
        /// </summary>
        public Email()
        {
            InicializeValores();
            if (EnviarEmail())
                MessageBox.Show("Email enviado com sucesso!!!");
            else
                MessageBox.Show("Erro ao enviar o email");

        }

        /// <summary>
        /// Inicializa os valores das variáveis
        /// </summary>
        public void InicializeValores()
        {
            envioOK = false;
            emailDestinatario = "emaildestinatario@hotmail.com";
            assunto = "Assunto do Email";
            mensagem = "Mensagem de teste do sistema para envio de email";

            emailAdm = "seuemailaqui@hotmail.com";
            servidor = "hotmail.com";
            senha = "*******";

        }

        /// <summary>
        /// Método para envio do email
        /// </summary>
        /// <returns>retorna true caso o envio seja feito e false caso contrário</returns>
        public bool EnviarEmail()
        {
            try
            {
                // Configura o corpo da mensagem a ser enviada
                email.From = new MailAddress(emailAdm); // cria obj com email iformado
                email.To.Add(emailDestinatario);
                email.Subject = assunto;
                email.Body = mensagem;

                //Cria o objeto do cliente servidor 
                SmtpClient smtp = new SmtpClient();

                //verifica qual servidor enviará a mensagem. 
                if (servidor == "gmail.com")
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                }

                if (servidor == "yahoo.com.br")
                {
                    smtp.Host = "smtp.mail.yahoo.br";
                    smtp.Port = 587;
                }

                if (servidor == "outlook.com" || servidor == "hotmail.com")
                {
                    smtp.Host = "smtp.outlook.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                }

                // Cria um objeto do servidor com a senha e login informado na classe ConfiguracaoLogin.
                // O objeto usa seu email e sua senha e faz o envio do email através destes dados.
                smtp.Credentials = new System.Net.NetworkCredential(emailAdm, senha);
                smtp.Send(email);

                //Define o estado de envio do email como ok.
                envioOK = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao enviar e-mail: " + ex.Message);
            }

            return envioOK;
        }
    }
}
