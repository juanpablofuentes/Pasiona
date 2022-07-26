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
    public class ProfesionalesActividadesController : Controller
    {
        private readonly Contexto _context;

        public ProfesionalesActividadesController(Contexto context)
        {
            _context = context;
        }

        // GET: ProfesionalesActividades
        public async Task<IActionResult> Index()
        {
            var contexto = _context.ProfesionalesActividades.Include(p => p.Actividad).Include(p => p.Profesional);
            return View(await contexto.ToListAsync());
        }

        // GET: ProfesionalesActividades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ProfesionalesActividades == null)
            {
                return NotFound();
            }

            var profesionalesActividades = await _context.ProfesionalesActividades
                .Include(p => p.Actividad)
                .Include(p => p.Profesional)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (profesionalesActividades == null)
            {
                return NotFound();
            }

            return View(profesionalesActividades);
        }

        // GET: ProfesionalesActividades/Create
        public IActionResult Create()
        {
            ViewData["ActividadId"] = new SelectList(_context.Actividad, "Id", "Nombre");
            ViewData["ProfesionalId"] = new SelectList(_context.Profesionales, "Id", "Nombre");
            return View();
        }

        // POST: ProfesionalesActividades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProfesionalId,ActividadId,Precio")] ProfesionalesActividades profesionalesActividades)
        {
            if (ModelState.IsValid)
            {
                _context.Add(profesionalesActividades);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ActividadId"] = new SelectList(_context.Actividad, "Id", "Nombre", profesionalesActividades.ActividadId);
            ViewData["ProfesionalId"] = new SelectList(_context.Profesionales, "Id", "Nombre", profesionalesActividades.ProfesionalId);
            return View(profesionalesActividades);
        }

        // GET: ProfesionalesActividades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ProfesionalesActividades == null)
            {
                return NotFound();
            }

            var profesionalesActividades = await _context.ProfesionalesActividades.FindAsync(id);
            if (profesionalesActividades == null)
            {
                return NotFound();
            }
            ViewData["ActividadId"] = new SelectList(_context.Actividad, "Id", "Id", profesionalesActividades.ActividadId);
            ViewData["ProfesionalId"] = new SelectList(_context.Profesionales, "Id", "Id", profesionalesActividades.ProfesionalId);
            return View(profesionalesActividades);
        }

        // POST: ProfesionalesActividades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProfesionalId,ActividadId,Precio")] ProfesionalesActividades profesionalesActividades)
        {
            if (id != profesionalesActividades.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(profesionalesActividades);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfesionalesActividadesExists(profesionalesActividades.Id))
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
            ViewData["ActividadId"] = new SelectList(_context.Actividad, "Id", "Id", profesionalesActividades.ActividadId);
            ViewData["ProfesionalId"] = new SelectList(_context.Profesionales, "Id", "Id", profesionalesActividades.ProfesionalId);
            return View(profesionalesActividades);
        }

        // GET: ProfesionalesActividades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ProfesionalesActividades == null)
            {
                return NotFound();
            }

            var profesionalesActividades = await _context.ProfesionalesActividades
                .Include(p => p.Actividad)
                .Include(p => p.Profesional)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (profesionalesActividades == null)
            {
                return NotFound();
            }

            return View(profesionalesActividades);
        }

        // POST: ProfesionalesActividades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ProfesionalesActividades == null)
            {
                return Problem("Entity set 'Contexto.ProfesionalesActividades'  is null.");
            }
            var profesionalesActividades = await _context.ProfesionalesActividades.FindAsync(id);
            if (profesionalesActividades != null)
            {
                _context.ProfesionalesActividades.Remove(profesionalesActividades);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfesionalesActividadesExists(int id)
        {
          return (_context.ProfesionalesActividades?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
