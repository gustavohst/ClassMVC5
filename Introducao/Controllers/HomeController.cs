using Introducao.Models;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            /*
              This whay is not recomended to use in MVC because is not clean. 
                var pessoa2 = new Pessoa();
                pessoa2.PessoaId = 1;
                pessoa2.Nome = "Gustavo Tenório";
                pessoa2.Tipo = "Administrador";
            */
            var pessoa = new Pessoa
            {
                PessoaId = 1,
                Nome = "Gustavo Tenório",
                Tipo = "Administrador"
            };

            /*  Associating data with view
            ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Tipo"] = pessoa.Tipo;
            */       
            /* Associating data with view bag
            ViewBag.id = pessoa.PessoaId;
            ViewBag.nome = pessoa.Nome;
            ViewBag.tipo = pessoa.Tipo;
            */
            return View(pessoa);
        }

        public ActionResult Contatos()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Lista(int PessoaId, string Nome, string Tipo)
        {
            ViewData["PessoaId"] = PessoaId;
            ViewData["Nome"] = Nome;
            ViewData["Tipo"] = Tipo;
            
            return View();
        }

    }
}