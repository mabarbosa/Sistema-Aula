using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Infraestrutura;

namespace Sistema.Negocio.UsuarioNegocio
{
    public interface IUsuarioNegocio
    {
        bool VerificaUsuario(Usuario usuario);

        bool VerificaUsuario(string login, string senha);
    }
}
