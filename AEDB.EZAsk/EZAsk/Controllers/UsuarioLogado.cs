using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZAsk.Helper;
using EZAsk.Repository;

namespace EZAsk.Controllers
{
    class UsuarioLogado :IDisposable
    {
        
        RepositoryUsuario _RepositoryUsuario;
        RepositoryCidade _RepositoryCidade;
        RepositoryEstado _RepositoryEstado;
        RepositoryTipoUsuario _RepositoryTipoUs;
        private string emailUsuario;

        public UsuarioLogado()
        {
            _RepositoryCidade = new RepositoryCidade();
            _RepositoryUsuario = new RepositoryUsuario();
            _RepositoryEstado = new RepositoryEstado();
            _RepositoryTipoUs = new RepositoryTipoUsuario();
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

        public Usuario Selecionar(string str)
        {
            return _RepositoryUsuario.Selecionar(str);
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

        /**** Cidade ****/

        public Cidade SelecionarCidade(int cod)
        {
            return _RepositoryCidade.Selecionar(cod);
        }

        public List<Cidade> SelecionarTodasCidades()
        {
            return _RepositoryCidade.SelecionarTodas();
        }

        /**** Estado ****/

        public Estado SelecionarEstado(int cod)
        {
            return _RepositoryEstado.Selecionar(cod);
        }

        public List<Estado> SelecionarTodosEstados()
        {
            return _RepositoryEstado.SelecionarTodos();
        }

        /**** Tipo usuario ****/

        public TipoUsuario SelecionarTipoUs(int cod)
        {
            return _RepositoryTipoUs.Selecionar(cod);
        }

        public List<TipoUsuario> SelecionarTodosTipoUs()
        {
            return _RepositoryTipoUs.SelecionarTodos();
        }

        public void setUsuarioLogado(string email)
        {
            this.emailUsuario = email;
        }

        public void Dispose()
        {
            _RepositoryUsuario.Dispose();
            _RepositoryCidade.Dispose();
            _RepositoryEstado.Dispose();
            _RepositoryTipoUs.Dispose();
        }
    }
}
