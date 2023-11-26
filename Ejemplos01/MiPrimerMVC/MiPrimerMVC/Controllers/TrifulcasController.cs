using Microsoft.AspNetCore.Mvc;

namespace MiPrimerMVC.Controllers
{
    public class TrifulcasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
