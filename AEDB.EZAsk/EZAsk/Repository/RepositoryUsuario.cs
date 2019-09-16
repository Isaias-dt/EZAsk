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

        public Usuario ValidaUsuario(string nick, string senha)
        {
            senha = Criptografia.gerarHashMd5(senha);
            //FirstOrDefault() : se não achar registro no campo da tabela retorna null.
            return (from p in oDb.Usuario where (p.EmailUsuario == nick || p.NomeLogin == nick) && p.SenhaUsuario == senha select p).FirstOrDefault();
        }

        public List<Usuario> SelecionarTodos()
        {
            return (from p in oDb.Usuario orderby p.IDUsuario select p).ToList();
        }

        // Proucura usuario no banco se achou vai retornar Usuario se não null.
        public Usuario ProucuraNick(string nick)
        {
            return (from p in oDb.Usuario where p.NomeLogin == nick select p).FirstOrDefault();
           
        }

        // Proucura email no banco se achou vai retornar Email se não null.
        public Usuario ProucuraEmail(string email)
        {
            return (from p in oDb.Usuario where p.EmailUsuario == email select p).FirstOrDefault();

        }

        public void Dispose()
        {
            oDb.Dispose();
        }
    }
}
