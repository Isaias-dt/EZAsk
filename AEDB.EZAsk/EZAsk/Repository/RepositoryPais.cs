using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZAsk.Helper;

namespace EZAsk.Repository
{
    public class RepositoryPais:IDisposable
    {
        EZAskEntities oDb;

        public RepositoryPais()
        {
            oDb = MyGlobal.getDataContext();
        }

        public void Incluir(Pais oPais)
        {
            oDb.Pais.Add(oPais);
            oDb.SaveChanges();
        }

        public void Alterar(Pais oPais)
        {
            oDb.Entry(oPais).State = System.Data.Entity.EntityState.Modified;
            oDb.SaveChanges();
        }

        public void Excluir(Pais oPais, bool foraContexto = false)
        {
            if (foraContexto)
            {
                oDb.Pais.Attach(oPais);
            }
            oDb.Pais.Remove(oPais);
            oDb.SaveChanges();
        }

        public Pais Selecionar(int cod)
        {
            //FirstOrDefault() : se não achar registro no campo da tabela retorna null.
            return (from p in oDb.Pais where p.id == cod select p).FirstOrDefault();
        }

        public List<Pais> SelecionarTodos()
        {
            return (from p in oDb.Pais orderby p.id select p).ToList();
        }

        public void Dispose()
        {
            oDb.Dispose();
        }
    }
}
