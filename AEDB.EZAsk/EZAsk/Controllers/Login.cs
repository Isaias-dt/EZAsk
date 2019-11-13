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

        public Usuario Selecionar(string str)
        {
            return _RepositoryUsuario.Selecionar(str);
        }

        public Usuario AutenticaUsuario(string nick, string senha)
        {
            return _RepositoryUsuario.ValidaUsuario(nick, senha);
        }

        public Usuario verificaUsLogado(string str)
        {
            return _RepositoryUsuario.Selecionar(str);
        }

        public void Dispose()
        {
            _RepositoryUsuario.Dispose();
        }
    }
}
