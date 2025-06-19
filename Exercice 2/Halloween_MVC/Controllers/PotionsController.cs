using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Halloween.Data;
using Halloween.Models;
using Halloween.ViewModels;

namespace Halloween.Controllers
{
    public class PotionsController : Controller
    {
        private readonly HalloweenContext _context;

        public PotionsController(HalloweenContext context)
        {
            _context = context;
        }

        // GET: Potions
        public async Task<IActionResult> Index()
        {
            var halloweenContext = _context.Potions.ToListAsync();
            return View(await halloweenContext);
        }

        // GET: Potions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Potions == null)
            {
                return NotFound();
            }

            var potion = await _context.Potions
                .Include(p => p.Creatrice)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (potion == null)
            {
                return NotFound();
            }

            return View(potion);
        }

        public async Task<IActionResult> Grimoire(int? id)
        {
            if (id == null || _context.Sorcieres == null)
            {
                return NotFound();
            }

            var sorciere = await _context.Sorcieres
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sorciere == null)
            {
                return NotFound();
            }


            Grimoire_VM grimoire_VM = new Grimoire_VM();
            grimoire_VM.Sorciere = sorciere;
            //COMPLÉTEZ ICI
            return View(grimoire_VM);
        }

        // GET: Potions/Create
        public IActionResult Create()
        {
            ViewData["Sorciere_Id"] = new SelectList(_context.Sorcieres, "Id", "Id");
            return View();
        }

        // POST: Potions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom,DateCreation,Sorciere_Id")] Potion potion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(potion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Sorciere_Id"] = new SelectList(_context.Sorcieres, "Id", "Id", potion.Sorciere_Id);
            return View(potion);
        }

        // GET: Potions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Potions == null)
            {
                return NotFound();
            }

            var potion = await _context.Potions.FindAsync(id);
            if (potion == null)
            {
                return NotFound();
            }
            ViewData["Sorciere_Id"] = new SelectList(_context.Sorcieres, "Id", "Id", potion.Sorciere_Id);
            return View(potion);
        }

        // POST: Potions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom,DateCreation,Sorciere_Id")] Potion potion)
        {
            if (id != potion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(potion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PotionExists(potion.Id))
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
            ViewData["Sorciere_Id"] = new SelectList(_context.Sorcieres, "Id", "Id", potion.Sorciere_Id);
            return View(potion);
        }

        // GET: Potions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Potions == null)
            {
                return NotFound();
            }

            var potion = await _context.Potions
                .Include(p => p.Creatrice)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (potion == null)
            {
                return NotFound();
            }

            return View(potion);
        }

        // POST: Potions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Potions == null)
            {
                return Problem("Entity set 'HalloweenContext.Potions'  is null.");
            }
            var potion = await _context.Potions.FindAsync(id);
            if (potion != null)
            {
                _context.Potions.Remove(potion);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PotionExists(int id)
        {
          return (_context.Potions?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
