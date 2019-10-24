using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZAsk.Helper;

namespace EZAsk.Repository
{
    public class RepositoryCidade:IDisposable
    {
        EZAskEntities oDb;

        public RepositoryCidade()
        {
            oDb = MyGlobal.getDataContext();
        }

        public Cidade Selecionar(int cod)
        {
            return (from p in oDb.Cidade where p.id == cod select p).FirstOrDefault();
        }

        public List<Cidade> SelecionarTodas()
        {
            //var Estado = (from e in oDb.Estado where e.uf == UF select e);
            //return (from p in oDb.Cidade where p.uf == estado select p).ToList();

            return (from p in oDb.Cidade orderby p.nome select p).ToList();
        }

        //public List<Cidade> SelecionarTodasUF(string UF)
        //{
        //    var estado = (from e in oDb.Estado where e.nome == UF select e.id);
        //    //return (from p in oDb.Cidade where p.uf == estado select p).ToList();
        //}

        public void Dispose()
        {
            oDb.Dispose();
        }
    }
}
