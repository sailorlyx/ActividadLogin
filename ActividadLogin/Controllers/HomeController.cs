using ActividadLogin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ActividadLogin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UsuarioModel usuarioModel)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Mensaje = "ta bien c:";
                return View("Index");
            }
            else
            {
                ViewBag.Mensaje = "ta mal :c";
                return View("Index", usuarioModel);
            }

        }
    }
}
