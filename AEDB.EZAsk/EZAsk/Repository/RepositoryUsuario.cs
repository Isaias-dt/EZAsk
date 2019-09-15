using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZAsk.Helper;

namespace EZAsk.Repository
{
    public class RepositoryUsuario:IDisposable
    {
        EZAskEntities oDb;

        public RepositoryUsuario()
        {
            oDb = MyGlobal.getDataContext();
        }

        public void Incluir(Usuario oUsuario)
        {
            oDb.Usuario.Add(oUsuario);
            oDb.SaveChanges();
        }

        public void Alterar(Usuario oUsuario)
        {
            oDb.Entry(oUsuario).State = System.Data.Entity.EntityState.Modified;
            oDb.SaveChanges();
        }

        public void Excluir(Usuario oUsuario, bool foraContexto = false)
        {
            if (foraContexto)
            {
                oDb.Usuario.Attach(oUsuario);
            }
            oDb.Usuario.Remove(oUsuario);
            oDb.SaveChanges();
        }

        public Usuario Selecionar(int Codigo)
        {
            //FirstOrDefault() : se não achar registro no campo da tabela retorna null.
            return (from p in oDb.Usuario where p.IDUsuario == Codigo select p).FirstOrDefault();
        }

        public List<Usuario> SelecionarTodos()
        {
            return (from p in oDb.Usuario orderby p.IDUsuario select p).ToList();
        }

        public bool AchaUsuario(string login)
        {
            Usuario existe = (from p in oDb.Usuario where p.NomeLogin == login select p).FirstOrDefault();
            if(existe == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Dispose()
        {
            oDb.Dispose();
        }
    }
}
