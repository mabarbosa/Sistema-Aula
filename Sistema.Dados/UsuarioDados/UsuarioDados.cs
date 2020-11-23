using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Infraestrutura;

namespace Sistema.Dados.UsuarioDados
{
    public class UsuarioDados : IUsuarioDados
    {
        #region ATRIBUTOS E CONSTRUTOR
        private EstudodbEntities db = null;

        public UsuarioDados(EstudodbEntities db)
        {
            this.db = db;
        }
        #endregion

        public bool VerificaUsuario(Usuario usuario)
        {
            return this.VerificaUsuario(usuario.login, usuario.senha);
        }

        public bool VerificaUsuario(string login, string senha)
        {
            Boolean isValid = false;

            Usuario usuario = db.Usuario.FirstOrDefault(x => x.login.Equals(login) && x.senha.Equals(senha) && x.ativo == true);

            if (usuario != null)
            {
                isValid = true;
            }

            return isValid;
        }
    }
}
 