using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Sistema.Negocio.UsuarioNegocio;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using Sistema.Infraestrutura;
using Sistema.Dados.UsuarioDados;

namespace Sistema.API.Segurança
{
    public class AuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated(); // Valida o TOKEN no contexto que OAuth é responsavel - Valida TOKEN
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            // Adiciona no cabeçalho a origem da requisicao
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" }); //Permite todos os 

            String login = context.UserName;
            String senha = context.Password;

            try
            {
                bool retorno = false;

                var db = new EstudodbEntities();
                var usuarioDados = new UsuarioDados(db);
                var usuarioNegocios = new UsuarioNegocio(usuarioDados);

                retorno = usuarioNegocios.VerificaUsuario(login, senha);

                if (!retorno)
                {
                    return;
                }

                //Identifica o usuário
                var identidade = new ClaimsIdentity(context.Options.AuthenticationType);
                identidade.AddClaim(new Claim(ClaimTypes.Name, login));

                //Atribui Roles
                var roles = new String[] { };
                foreach (var role in roles)
                {
                    identidade.AddClaim(new Claim(ClaimTypes.Role, role));
                }

                GenericPrincipal principal = new GenericPrincipal(identidade, roles.ToArray());
                Thread.CurrentPrincipal = principal; // Configura na Thread  principal para poder recuperar no controle

                context.Validated(identidade);
            }
            catch(Exception e)
            {
                context.SetError("Falha de Autenticação", "Falha ao realizar Autenticação.\n\n"+ e.Message);
            }
        }

    }
}