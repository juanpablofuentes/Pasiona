using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MiPrimerMVC.Models;

namespace MiPrimerMVC.Controllers
{
    public class PajaritosController : Controller
    {
        private readonly Contexto _context;

        public PajaritosController(Contexto context)
        {
            _context = context;
        }

        // GET: Pajaritos
        public async Task<IActionResult> Index()
        {
              return _context.Pajaritos != null ? 
                          View(await _context.Pajaritos.ToListAsync()) :
                          Problem("Entity set 'Contexto.Pajaritos'  is null.");
        }

        // GET: Pajaritos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Pajaritos == null)
            {
                return NotFound();
            }

            var pajarito = await _context.Pajaritos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pajarito == null)
            {
                return NotFound();
            }

            return View(pajarito);
        }

        // GET: Pajaritos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pajaritos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Vuela,Sonido")] Pajarito pajarito)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pajarito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pajarito);
        }

        // GET: Pajaritos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Pajaritos == null)
            {
                return NotFound();
            }

            var pajarito = await _context.Pajaritos.FindAsync(id);
            if (pajarito == null)
            {
                return NotFound();
            }
            return View(pajarito);
        }

        // POST: Pajaritos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Vuela,Sonido")] Pajarito pajarito)
        {
            if (id != pajarito.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pajarito);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PajaritoExists(pajarito.Id))
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
            return View(pajarito);
        }

        // GET: Pajaritos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Pajaritos == null)
            {
                return NotFound();
            }

            var pajarito = await _context.Pajaritos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pajarito == null)
            {
                return NotFound();
            }

            return View(pajarito);
        }

        // POST: Pajaritos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Pajaritos == null)
            {
                return Problem("Entity set 'Contexto.Pajaritos'  is null.");
            }
            var pajarito = await _context.Pajaritos.FindAsync(id);
            if (pajarito != null)
            {
                _context.Pajaritos.Remove(pajarito);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PajaritoExists(int id)
        {
          return (_context.Pajaritos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
