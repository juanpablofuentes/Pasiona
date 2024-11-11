using CapaServicio.Models;
using CapaServicio.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CapaServicio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAlumnoService _service;

        public HomeController(IAlumnoService service,ILogger<HomeController> logger)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            var foo = _service.ObtenerPorId(1);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
