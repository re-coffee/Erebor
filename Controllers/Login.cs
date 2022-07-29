using Erebor.DAL;
using Erebor.Models;
using Microsoft.AspNetCore.Mvc;

namespace Erebor.Controllers
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Autorizar(Usuario userSite)
        {
            using (var contexto = new EreborContexto())
            {
                Usuario? userDb = contexto.Usuarios
                    .Where(x => x.Nome == userSite.Nome)
                    .FirstOrDefault();

                if (userDb != null && userDb.CheckSenha(userSite.Senha))
                {
                    return RedirectToAction("Index", "Inicio");
                }
                else
                {
                    userSite.ErroLogin = "⚠️ Usuário e/ou senha incorreto(s)";
                    return View("Index", userSite);
                }
            }
        }
    }
}
