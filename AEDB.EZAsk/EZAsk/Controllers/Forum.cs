using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZAsk.Repository;
using EZAsk.Helper;

namespace EZAsk.Controllers
{
    class Forum
    {
        RepositoryForum _RepositoryForum;
        RepositoryCidade _RepositoryCidade;
        RepositoryEstado _RepositoryEstado;
        RepositoryFormacao _RepositoryFormacao;

        public Forum()
        {
            _RepositoryCidade = new RepositoryCidade();
            _RepositoryForum = new RepositoryForum();
            _RepositoryEstado = new RepositoryEstado();
            _RepositoryFormacao = new RepositoryFormacao();

        }

        public void Incluir(Forum oForum)
        {
            _RepositoryForum.Incluir(oForum);
        }

        public void Alterar(Forum oForum)
        {
            _RepositoryForum.Alterar(oForum);
        }

        public void Excluir(Forum oForum)
        {
            _RepositoryForum.Excluir(oForum);
        }

        public Forum Selecionar(int id)
        {
            return _RepositoryForum.Selecionar(id);
        }

        public List<Forum> SelecionarTodos()
        {
            return _RepositoryForum.SelecionarTodos();
        }

        /**** Cidade ****/

        public Cidade SelecionarCidade(int cod)
        {
            return _RepositoryCidade.Selecionar(cod);
        }

        /**** Estado ****/

        public Estado SelecionarEstado(int cod)
        {
            return _RepositoryEstado.Selecionar(cod);
        }

        /**** formacão ****/

        public Formacao SelecionarFormacao(int cod)
        {
            return _RepositoryFormacao.Selecionar(cod);
        }

        public void Dispose()
        {
            _RepositoryForum.Dispose();
            _RepositoryCidade.Dispose();
            _RepositoryEstado.Dispose();
            _RepositoryFormacao.Dispose();
        }
    }
}
