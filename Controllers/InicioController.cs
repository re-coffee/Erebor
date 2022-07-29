using Erebor.Models;
using Microsoft.AspNetCore.Mvc;

namespace Erebor.Controllers
{
    public class InicioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
