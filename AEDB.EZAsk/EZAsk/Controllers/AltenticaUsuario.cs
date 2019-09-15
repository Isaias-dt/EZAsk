using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZAsk.Helper;
using EZAsk.Repository;

namespace EZAsk.Controllers
{
    class AltenticaUsuario :IDisposable
    {
        RepositoryUsuario _RepositoryUsuario;

        public bool AchaUsuario(string login)
        {
            return _RepositoryUsuario.AchaUsuario(login);
        }

        public void Dispose()
        {
            _RepositoryUsuario.Dispose();
        }
    }
}
