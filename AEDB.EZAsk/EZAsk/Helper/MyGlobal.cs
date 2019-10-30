using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZAsk.Helper
{
    public class MyGlobal
    {
        private static FrmPrincipal instanceMdiParentFrmPrincipal;

        public static EZAskEntities getDataContext()
        {
            EZAskEntities oDb = new EZAskEntities();
            oDb.Configuration.ProxyCreationEnabled = false;
            return oDb;
        }

        public static string MsgErro(Exception ex)
        {
            string erro = ex.Message;
            Exception ex1 = ex.InnerException;
            while (ex1 != null)
            {
                erro = " - " + ex1.Message;
                ex1 = ex1.InnerException;
            }
            return erro;
        }

        // Valida Email.
        public static bool ValidarEmail(string strEmail)
        {
            string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(strEmail, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Valida Nome do Usuario.
        public static bool ValidarNome(string strNome)
        {
            string strModelo = "^[a-z A-Z]+$";
            if (System.Text.RegularExpressions.Regex.IsMatch(strNome, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Valida Nick.
        public static bool ValidarNick(string strNick)
        {
            string strModelo = "^[a-zA-Z0-9]+([._-]?[a-zA-Z0-9]+)?$";
            if (System.Text.RegularExpressions.Regex.IsMatch(strNick, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //Valida Senha.
        public static bool ValidarSenha(string strSenha)
        {
            string strModelo = "^[a-zA-Z0-9]*[._-]{4}$";
            if (System.Text.RegularExpressions.Regex.IsMatch(strSenha, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void limitarDigitoSenha(KeyPressEventArgs e)
        {
            // [a-z][A-Z][0-9][.-_]
            if (!(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-' || e.KeyChar == '_') && e.KeyChar != (char)8)
                e.Handled = true;
        }

        // Função singleton do frmPrincipa.
        public static FrmPrincipal InstanceFrmPrincipal()
        {
            if (instanceMdiParentFrmPrincipal == null)
            {
                return instanceMdiParentFrmPrincipal = new FrmPrincipal();
            }
            return instanceMdiParentFrmPrincipal;
        }

        /***** Metodos enviar e retorna imagens do o banco *****/
        
        // Trasfoma img em bites.
        public static byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, ImageFormat.Gif);
            return ms.ToArray();
        }
        // Trasforma bites em img.
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            var ms = new MemoryStream(byteArrayIn);
            var returnImage = Image.FromStream(ms);
            return returnImage;
        }

        // Metodo que inseri o form dentro do panel.
        public static void abrirFrmFilho(object formFilho, Panel pnlConteiner, bool Dock = true)
        {
            if (pnlConteiner.Controls.Count > 0)
                pnlConteiner.Controls.RemoveAt(0);
            Form frmF = formFilho as Form;
            frmF.TopLevel = false;
            if (Dock)
            {
                frmF.Dock = DockStyle.Fill;
            }
            pnlConteiner.Controls.Add(frmF);
            pnlConteiner.Tag = frmF;
            frmF.Show();
        }
    }
}
