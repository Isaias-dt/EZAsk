using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZAsk.Helper;
using EZAsk.Repository;

namespace EZAsk.Controllers
{
    class Login :IDisposable
    {
        RepositoryUsuario _RepositoryUsuario = new RepositoryUsuario();

        public Usuario AutenticaUsuario(string nick, string senha)
        {
            return _RepositoryUsuario.ValidaUsuario(nick, senha);
        }

        public void Dispose()
        {
            _RepositoryUsuario.Dispose();
        }
    }
}
