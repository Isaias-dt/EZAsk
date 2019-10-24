using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZAsk.Helper;

namespace EZAsk.Repository
{
    public class RepositoryTipoUsuario:IDisposable
    {
        EZAskEntities oDb;

        public RepositoryTipoUsuario()
        {
            oDb = MyGlobal.getDataContext();
        }

        public TipoUsuario Selecionar(int cod)
        {
            return (from p in oDb.TipoUsuario where p.IDTipoUsuario == cod select p).FirstOrDefault();
        }

        public List<TipoUsuario> SelecionarTodos()
        {
            return (from p in oDb.TipoUsuario orderby p.NomeTipoUsuario select p).ToList();
        }

        public void Dispose()
        {
            oDb.Dispose();
        }
    }
}
