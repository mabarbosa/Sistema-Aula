using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Sistema.Negocio.PessoaNegocio;
using Sistema.Dados.PessoaDados;
using Sistema.Infraestrutura;

namespace Sistema.API.Controllers
{
    public class PessoaController : ApiController
    {
        IPessoaNegocio pessoaNegocio;

        public PessoaController(IPessoaNegocio _pessoaNegocio)
        {
            this.pessoaNegocio = _pessoaNegocio;
        }

        [HttpGet]
        [ActionName("BuscaPessoas")]
        public HttpResponseMessage BuscaPessoas()
        {
            try
            {
                var listaPessoas = pessoaNegocio.BuscaTodasPessoas();

                return Request.CreateResponse(HttpStatusCode.OK, listaPessoas);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e.ToString());
            }

        }

        [HttpGet]
        [ActionName("BuscaPessoaPorNome")]
        public HttpResponseMessage BuscaPessoaPorNome(String nome)
        {
            Pessoa pessoa = null;

            try
            {
                pessoa = pessoaNegocio.SelecionaPessoaPorNome(nome);

                return Request.CreateResponse(HttpStatusCode.OK, pessoa);
            }
            catch (Exception e)
            {
                if(e.Message.Equals("nulo"))
                {
                    return Request.CreateResponse(HttpStatusCode.NoContent, pessoa);
                }

                return Request.CreateResponse(HttpStatusCode.BadRequest, e.Message);
            }

        }
    }
}
