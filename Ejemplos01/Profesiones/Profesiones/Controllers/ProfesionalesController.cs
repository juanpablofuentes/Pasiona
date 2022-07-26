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
    public class ProfesionalesController : Controller
    {
        private readonly Contexto _context;

        public ProfesionalesController(Contexto context)
        {
            _context = context;
        }

        // GET: Profesionales
        public async Task<IActionResult> Index(String? buscar)
        {
            if (_context.Profesionales != null)
            {
                if (buscar != null)
                {
                    return View(await _context.Profesionales.Where(x=>x.Nombre.Contains(buscar)).ToListAsync());
                }
                else
                {
                    return View(await _context.Profesionales.ToListAsync());
                }

            }
            else { return Problem("Entity set 'Contexto.Profesionales'  is null."); }

        }

        // GET: Profesionales/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Profesionales == null)
            {
                return NotFound();
            }
            var misActividades = _context.ProfesionalesActividades.Where(x => x.ProfesionalId == id).Select(x => x.ActividadId).ToList();
            ViewData["ActividadId"] = new SelectList(_context.Actividad.Where(x => !misActividades.Contains(x.Id)), "Id", "Nombre");

            var profesional = await _context.Profesionales.Include(x => x.Actividades).ThenInclude(x => x.Actividad)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (profesional == null)
            {
                return NotFound();
            }

            return View(profesional);
        }

        // GET: Profesionales/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Profesionales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Telefono,Mail,Activo")] Profesional profesional)
        {
            if (ModelState.IsValid)
            {
                _context.Add(profesional);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(profesional);
        }

        [HttpPost]
        public async Task<IActionResult> AddActividad(int ActividadId, int ProfesionalId)
        {
            ProfesionalesActividades pa = _context.ProfesionalesActividades.Where(x => x.ActividadId == ActividadId && x.ProfesionalId == ProfesionalId).FirstOrDefault();
            if (pa == null)
            {
                pa = new ProfesionalesActividades();
                pa.ActividadId = ActividadId;
                pa.ProfesionalId = ProfesionalId;
                _context.Add(pa);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Details), new { Id = ProfesionalId });

        }

        // GET: Profesionales/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Profesionales == null)
            {
                return NotFound();
            }

            var profesional = await _context.Profesionales.FindAsync(id);
            if (profesional == null)
            {
                return NotFound();
            }
            return View(profesional);
        }

        // POST: Profesionales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Telefono,Mail,Activo")] Profesional profesional)
        {
            if (id != profesional.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(profesional);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfesionalExists(profesional.Id))
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
            return View(profesional);
        }

        // GET: Profesionales/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Profesionales == null)
            {
                return NotFound();
            }

            var profesional = await _context.Profesionales
                .FirstOrDefaultAsync(m => m.Id == id);
            if (profesional == null)
            {
                return NotFound();
            }

            return View(profesional);
        }

        // POST: Profesionales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Profesionales == null)
            {
                return Problem("Entity set 'Contexto.Profesionales'  is null.");
            }
            var profesional = await _context.Profesionales.FindAsync(id);
            if (profesional != null)
            {
                _context.Profesionales.Remove(profesional);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfesionalExists(int id)
        {
            return (_context.Profesionales?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
