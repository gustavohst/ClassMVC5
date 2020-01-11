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


            return View(pessoa); //View Tipada
        }

        public ActionResult Contatos()
        {
            return View();
        }

        [HttpPost] //Uso [HttpPost] apenas no metodo POST
        public ActionResult Lista(Pessoa pessoa)
        {
            return View(pessoa);
        }

    }
}