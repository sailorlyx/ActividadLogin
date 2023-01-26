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
                return View();
            }
            else
            {
                ViewBag.Mensaje = "ta mal :c";
                return View("Index", usuarioModel);
            }

        }

        public ActionResult Registro(RegistroModel registromodel)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Mensaje = "te has registrado correctamente c:";
                return View();
            }
            else
            {
                ViewBag.Mensaje = "no has introducido bien los datos, vuelve a empezar porfis";
                return View("Registro", registromodel);
            }
            
        }
    }
}
