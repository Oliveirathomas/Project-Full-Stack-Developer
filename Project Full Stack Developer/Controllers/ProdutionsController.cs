using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project_Full_Stack_Developer.Data;
using Project_Full_Stack_Developer.Models;

namespace Project_Full_Stack_Developer.Controllers
{
    public class ProdutionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProdutionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Produtions
        public async Task<IActionResult> Index()
        {
              return View(await _context.Prodution.ToListAsync());
        }

        // GET: Produtions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Prodution == null)
            {
                return NotFound();
            }

            var prodution = await _context.Prodution
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prodution == null)
            {
                return NotFound();
            }

            return View(prodution);
        }

        // GET: Produtions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Produtions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Adress,Description,DateOfCreation")] Prodution prodution)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prodution);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(prodution);
        }

        // GET: Produtions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Prodution == null)
            {
                return NotFound();
            }

            var prodution = await _context.Prodution.FindAsync(id);
            if (prodution == null)
            {
                return NotFound();
            }
            return View(prodution);
        }

        // POST: Produtions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Adress,Description,DateOfCreation")] Prodution prodution)
        {
            if (id != prodution.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prodution);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutionExists(prodution.Id))
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
            return View(prodution);
        }

        // GET: Produtions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Prodution == null)
            {
                return NotFound();
            }

            var prodution = await _context.Prodution
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prodution == null)
            {
                return NotFound();
            }

            return View(prodution);
        }

        // POST: Produtions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Prodution == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Prodution'  is null.");
            }
            var prodution = await _context.Prodution.FindAsync(id);
            if (prodution != null)
            {
                _context.Prodution.Remove(prodution);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutionExists(int id)
        {
          return _context.Prodution.Any(e => e.Id == id);
        }
    }
}
