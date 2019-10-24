using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZAsk.Helper;

namespace EZAsk.Repository
{
    public class RepositoryForum:IDisposable
    {
        EZAskEntities oDb;

        public RepositoryForum()
        {
            oDb = MyGlobal.getDataContext();
        }

        public void Incluir(Forum oForum)
        {
            oDb.Forum.Add(oForum);
            oDb.SaveChanges();
        }

        public void Alterar(Forum oForum)
        {
            oDb.Entry(oForum).State = System.Data.Entity.EntityState.Modified;
            oDb.SaveChanges();
        }

        public void Excluir(Forum oForum, bool foraContexto = false)
        {
            if (foraContexto)
            {
                oDb.Forum.Attach(oForum);
            }
            oDb.Forum.Remove(oForum);
            oDb.SaveChanges();
        }

        public Forum Selecionar(int cod)
        {
            //FirstOrDefault() : se não achar registro no campo da tabela retorna null.
            return (from p in oDb.Forum where p.IDPost == cod select p).FirstOrDefault();
        }

        public List<Forum> SelecionarTodos()
        {
            return (from p in oDb.Forum orderby p.IDPost select p).ToList();
        }

        public void Dispose()
        {
            oDb.Dispose();
        }
    }
}
