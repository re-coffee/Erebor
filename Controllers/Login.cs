using Microsoft.AspNetCore.Mvc;

namespace Erebor.Controllers
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Autorizar()
        {
            return RedirectToAction("Index", "Inicio");
        }
    }
}
