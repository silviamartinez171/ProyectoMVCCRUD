using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoMVCCRUD.Models;

namespace ProyectoMVCCRUD.Controllers
{
    public class NotasController : Controller
    {
        private readonly DBACTAContext _context;

        public NotasController(DBACTAContext context)
        {
            _context = context;
        }

        // GET: Notas
        public async Task<IActionResult> Index()
        {
              return View(await _context.Notasests.ToListAsync());
        }

        // GET: Notas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Notasests == null)
            {
                return NotFound();
            }

            var notasest = await _context.Notasests
                .FirstOrDefaultAsync(m => m.Id == id);
            if (notasest == null)
            {
                return NotFound();
            }

            return View(notasest);
        }

        // GET: Notas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Notas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Carnet,Apellido,Nombre,Ipn,Iipn,Sist,Proyec,Nf")] Notasest notasest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(notasest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(notasest);
        }

        // GET: Notas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Notasests == null)
            {
                return NotFound();
            }

            var notasest = await _context.Notasests.FindAsync(id);
            if (notasest == null)
            {
                return NotFound();
            }
            return View(notasest);
        }

        // POST: Notas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Carnet,Apellido,Nombre,Ipn,Iipn,Sist,Proyec,Nf")] Notasest notasest)
        {
            if (id != notasest.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(notasest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NotasestExists(notasest.Id))
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
            return View(notasest);
        }

        // GET: Notas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Notasests == null)
            {
                return NotFound();
            }

            var notasest = await _context.Notasests
                .FirstOrDefaultAsync(m => m.Id == id);
            if (notasest == null)
            {
                return NotFound();
            }

            return View(notasest);
        }

        // POST: Notas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Notasests == null)
            {
                return Problem("Entity set 'DBACTAContext.Notasests'  is null.");
            }
            var notasest = await _context.Notasests.FindAsync(id);
            if (notasest != null)
            {
                _context.Notasests.Remove(notasest);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NotasestExists(int id)
        {
          return _context.Notasests.Any(e => e.Id == id);
        }
    }
}
