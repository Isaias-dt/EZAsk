using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZAsk.Helper
{
    public class MyGlobal
    {
        FrmPrincipal frmPrincipal;
        private static FrmPrincipal instanceMdiParentFrmPrincipal; 

        public static EZAskEntities getDataContext ()
        {
            EZAskEntities oDb = new EZAskEntities();
            oDb.Configuration.ProxyCreationEnabled = false;
            return oDb;
        }

        public void EnableBtnMenu(bool menu)
        {
            frmPrincipal = new FrmPrincipal();
            frmPrincipal.menuLogin.Enabled = menu;
            frmPrincipal.menuCadastra.Enabled = menu;
            frmPrincipal.menuForum.Enabled = menu;
            frmPrincipal.menuSobre.Enabled = menu;
        }

        // Menssagem Exception tratada.
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
        //Valida Nome.
        public static bool ValidarNome(string strNome)
        {
            string strModelo = "";
            if (System.Text.RegularExpressions.Regex.IsMatch(strNome, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
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
    }
}
