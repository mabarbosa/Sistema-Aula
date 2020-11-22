using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Sistema.API.Controllers
{
    public class PessoaController : ApiController
    {
        // GET: Pessoa/BuscaPessoaPorNome/5
        [HttpGet]
        [ActionName("BuscaPessoaPorNome")]
        public HttpResponseMessage BuscaPessoaPorNome()
        {
            var objPessoa = new Sistema.Infraestrutura.Pessoa();
            objPessoa.nome = "Rodrigo";

            return Request.CreateResponse(HttpStatusCode.OK, objPessoa);
        }
    }
}
