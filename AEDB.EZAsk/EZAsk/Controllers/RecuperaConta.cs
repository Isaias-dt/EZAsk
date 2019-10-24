using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZAsk.Helper;
using EZAsk.Repository;

namespace EZAsk.Controllers
{
    class RecuperaConta :IDisposable
    {
        RepositoryUsuario _RepositoryUsuario;

        public RecuperaConta()
        {
            _RepositoryUsuario = new RepositoryUsuario();
        }

        public void Incluir(Usuario oUsuario)
        {
            _RepositoryUsuario.Incluir(oUsuario);
        }

        public Usuario Selecionar(string str)
        {
            return _RepositoryUsuario.Selecionar(str);
        }

        // retorna email ou null
        public Usuario getEmail(string email)
        {
            return _RepositoryUsuario.ProucuraEmail(email);
        }
        // retorna usuario ou null
        public Usuario getNick(string nick)
        {
            return _RepositoryUsuario.ProucuraNick(nick);
        }

        public void Dispose()
        {
            _RepositoryUsuario.Dispose();
        }
    }
}
