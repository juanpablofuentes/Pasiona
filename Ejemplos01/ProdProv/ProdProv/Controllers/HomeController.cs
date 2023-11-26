using Microsoft.AspNetCore.Mvc;
using ProdProv.Models;
using System.Diagnostics;

namespace ProdProv.Controllers
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
            return View("Index2");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public bool Hola(int Id)
        {
            return true;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}