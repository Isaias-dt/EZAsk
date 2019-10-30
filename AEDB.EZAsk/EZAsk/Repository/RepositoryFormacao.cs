using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZAsk.Helper;

namespace EZAsk.Repository
{
    public class RepositoryFormacao:IDisposable
    {
        EZAskEntities oDb;

        public RepositoryFormacao()
        {
            oDb = MyGlobal.getDataContext();
        }

        public Formacao Selecionar(int cod)
        {
            return (from p in oDb.Formacao where p.IDFormacao == cod select p).FirstOrDefault();
        }

        public List<Formacao> SelecionarTodos()
        {
            return (from p in oDb.Formacao orderby p.NomeFormacao select p).ToList();
        }

        public void Dispose()
        {
            oDb.Dispose();
        }
    }
}
