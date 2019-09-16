using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZAsk.Helper;
using EZAsk.Repository;

namespace EZAsk.Controllers
{
    class CadastraUsuario :IDisposable
    {
        RepositoryUsuario _RepositoryUsuario;

        public CadastraUsuario()
        {
            _RepositoryUsuario = new RepositoryUsuario();
        }

        public void Incluir(Usuario oUsuario)
        {
            _RepositoryUsuario.Incluir(oUsuario);
        }

        public void Alterar(Usuario oUsuario)
        {
            _RepositoryUsuario.Alterar(oUsuario);
        }

        public void Excluir(Usuario oUsuario)
        {
            _RepositoryUsuario.Excluir(oUsuario);
        }

        public Usuario Selecionar(int Codigo)
        {
            return _RepositoryUsuario.Selecionar(Codigo);
        }

        public List<Usuario> SelecionarTodos()
        {
            return _RepositoryUsuario.SelecionarTodos();
        }
        // retorna usuario ou null
        public Usuario getEmail(string email)
        {
            return _RepositoryUsuario.ProucuraEmail(email);
        }
        // retorna email ou null
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
