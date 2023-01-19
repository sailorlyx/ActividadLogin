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
        

    }
}
