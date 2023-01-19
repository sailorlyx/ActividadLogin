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
        //public ActionResult loginformu(FormCollection credenciales)
        //{
        //    string usuario = credenciales.Get("angel");
        //    string contra = credenciales.Get("calculadora");
        //    if (usuario == "angel" && contra == "calculadora")
        //    {
        //        //mensaje = "has iniciado sesion correctamente c:";
        //    }
        //    else
        //    {
        //        //mensaje = "nombre de usuario y/o contraseña incorrecta :c";

        //    }

        //    return View("Index");

        }
}
