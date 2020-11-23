using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Dados.UsuarioDados;
using Sistema.Infraestrutura;

namespace Sistema.Negocio.UsuarioNegocio
{
    public class UsuarioNegocio
    {

        #region ATRIBUTOS E CONSTRUTOR
        private IUsuarioDados usuarioDAO = null;

        public UsuarioNegocio(IUsuarioDados usuarioDAO)
        {
            this.usuarioDAO = usuarioDAO;
        }
        #endregion

        public bool VerificaUsuario(Usuario usuario)
        {
            return usuarioDAO.VerificaUsuario(usuario);
        }

        public bool VerificaUsuario(string login, string senha)
        {
            return usuarioDAO.VerificaUsuario(login, senha);
        }
    }
}
