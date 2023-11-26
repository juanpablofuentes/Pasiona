using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Profesiones.Models;

namespace Profesiones.Controllers
{
    public class Actividads1Controller : Controller
    {
        private readonly Contexto _context;

        public Actividads1Controller(Contexto context)
        {
            _context = context;
        }

        // GET: Actividads1
        public async Task<IActionResult> Index()
        {
              return View(await _context.Actividad.ToListAsync());
        }

        // GET: Actividads1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Actividad == null)
            {
                return NotFound();
            }

            var actividad = await _context.Actividad
                .FirstOrDefaultAsync(m => m.Id == id);
            if (actividad == null)
            {
                return NotFound();
            }

            return View(actividad);
        }

        // GET: Actividads1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Actividads1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] Actividad actividad)
        {
            if (ModelState.IsValid)
            {
                _context.Add(actividad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(actividad);
        }

        // GET: Actividads1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Actividad == null)
            {
                return NotFound();
            }

            var actividad = await _context.Actividad.FindAsync(id);
            if (actividad == null)
            {
                return NotFound();
            }
            return View(actividad);
        }

        // POST: Actividads1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] Actividad actividad)
        {
            if (id != actividad.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(actividad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActividadExists(actividad.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(actividad);
        }

        // GET: Actividads1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Actividad == null)
            {
                return NotFound();
            }

            var actividad = await _context.Actividad
                .FirstOrDefaultAsync(m => m.Id == id);
            if (actividad == null)
            {
                return NotFound();
            }

            return View(actividad);
        }

        // POST: Actividads1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Actividad == null)
            {
                return Problem("Entity set 'Contexto.Actividad'  is null.");
            }
            var actividad = await _context.Actividad.FindAsync(id);
            if (actividad != null)
            {
                _context.Actividad.Remove(actividad);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActividadExists(int id)
        {
          return _context.Actividad.Any(e => e.Id == id);
        }
    }
}
