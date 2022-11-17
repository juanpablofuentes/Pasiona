using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Profesiones.Models;

namespace Profesiones.Controllers
{
    public class TestController : Controller
    {
        private readonly Contexto _context;
        public TestController(Contexto context)
        {
            _context = context;
        }
        // GET: TestController
        public ActionResult Index()
        {
            var prof = _context.Profesionales.First();
            ViewData["Nombre"] = "Juan";
            return View(prof);
        }

        // GET: TestController/Details/5
        public ActionResult Details(int id)
        {
            var prof = _context.Profesionales.Find(id);
            if (prof == null)
            {
                return Content("<h1>No he encontrado nada</h1>");
            }
            return View("Index",prof);
        }

        // GET: TestController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TestController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TestController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TestController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TestController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
