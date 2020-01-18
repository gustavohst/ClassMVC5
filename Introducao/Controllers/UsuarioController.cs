using Introducao.Models;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Usuario()
        {
            var usuario = new Usuario();
            return View(usuario);
        }

        [HttpPost]
        public ActionResult Usuario(Usuario usuario)
        {

            if(string.IsNullOrEmpty(usuario.Nome))
            {
                ModelState.AddModelError("Nome", "O campo nome é obrigatório");
            }

            if (usuario.Senha != usuario.ConfirmarSenha)
            {
                ModelState.AddModelError("", "O campo senha deve ser identica");
            }

            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }
            return View(usuario);
        }

        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }

        public ActionResult LoginUnico(string login)
        {
            var bdExemplo = new Collection<string>
            {
                "Hugo",
                "Freitas",
                "Paula"
            };
            return Json(bdExemplo.All(x => x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }

    }
}