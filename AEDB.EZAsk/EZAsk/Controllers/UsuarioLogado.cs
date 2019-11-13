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
        RepositoryFormacao _RepositoryFormacao;

        private static string idEmailLogado = "isaias-dt@hotmail.com";

        public string IdEmailLogado { get => idEmailLogado; set => idEmailLogado = value; }

        public UsuarioLogado()
        {   
            _RepositoryCidade = new RepositoryCidade();
            _RepositoryUsuario = new RepositoryUsuario();
            _RepositoryEstado = new RepositoryEstado();
            _RepositoryFormacao = new RepositoryFormacao();

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

        public Usuario AutenticaUsuario(string nick, string senha)
        {
            return _RepositoryUsuario.ValidaUsuario(nick, senha);
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

        public List<Cidade> SelecionarTodasUf(int UF)
        {
            return _RepositoryCidade.SelecionarTodasUF(UF);
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

        /**** formacão ****/

        public Formacao SelecionarFormacao(int cod)
        {
            return _RepositoryFormacao.Selecionar(cod);
        }

        public List<Formacao> SelecionarTodasFormacao()
        {
            return _RepositoryFormacao.SelecionarTodos();
        }

        public void Dispose()
        {
            _RepositoryUsuario.Dispose();
            _RepositoryCidade.Dispose();
            _RepositoryEstado.Dispose();
            _RepositoryFormacao.Dispose();
        }
    }
}
