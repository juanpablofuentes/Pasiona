using Microsoft.AspNetCore.Mvc;
using Profesiones.Models;
using System.Diagnostics;

namespace Profesiones.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPut]
        public IActionResult Privacy()
        {
            return Content("PUT como texto ojo.");
        }

        [HttpPost]
        [ActionName("Privacy")]
        public IActionResult Privacy2(String? nombre)
        {
            return Content("POST para probar "+nombre);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}