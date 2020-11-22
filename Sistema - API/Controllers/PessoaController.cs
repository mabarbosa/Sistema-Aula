using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema.WebAPI.Controllers
{
    public class PessoaController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BuscaNomePessoa(string pessoa)
        {
            return View();
        }
    }
}
