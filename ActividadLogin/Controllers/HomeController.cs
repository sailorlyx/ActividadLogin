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
                ViewBag.Mensaje = "Dios Cris te como la boca <3";
                return View("Index");
            }
            else
            {
                ViewBag.Mensaje = "Ta mal";
                return View("Index", usuarioModel);
            }

        }
    }
}
