using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZAsk.Helper;

namespace EZAsk.Repository
{
    public class RepositoryEstado:IDisposable
    {
        EZAskEntities oDb;

        public RepositoryEstado()
        {
            oDb = MyGlobal.getDataContext();
        }

        public Estado Selecionar(int cod)
        {
            //FirstOrDefault() : se não achar registro no campo da tabela retorna null.
            return (from p in oDb.Estado where p.id == cod select p).FirstOrDefault();
        }

        public List<Estado> SelecionarTodos()
        {
            return (from p in oDb.Estado orderby p.uf select p).ToList();
        }

        public void Dispose()
        {
            oDb.Dispose();
        }
    }
}
