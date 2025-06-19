using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Halloween.Data;
using Halloween.Models;
using System.Security.Policy;
using Halloween.ViewModels;

namespace Halloween.Controllers
{
    public class SorcieresController : Controller
    {
        private readonly HalloweenContext _context;

        public SorcieresController(HalloweenContext context)
        {
            _context = context;
        }

        // GET: Sorcieres
        public IActionResult Index()
        {
            //Modifiez ici
            List<Sorciere> ListeSorciere =  _context.Sorcieres.OrderBy(o => o.Origine).ThenBy(n => n.Nom).ToList();

            return View(ListeSorciere);
        }

        // GET: Sorcieres/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            Sorcieres_VM sorcieres_VM = new Sorcieres_VM();
            sorcieres_VM.Sorciere = await _context.Sorcieres.FirstOrDefaultAsync(p => p.Id == id);
            // TODO: Question 1
            
            if (sorcieres_VM == null)
            {
                return NotFound();
            }

            sorcieres_VM.NbPotion = _context.Potions.Count(p => p.Sorciere_Id == id);
            return View(sorcieres_VM);
        }

        // GET: Sorcieres/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sorcieres/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Sorciere sorciere)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sorciere);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sorciere);
        }

        // GET: Sorcieres/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Sorcieres == null)
            {
                return NotFound();
            }

            var sorciere = await _context.Sorcieres.FindAsync(id);
            if (sorciere == null)
            {
                return NotFound();
            }
            return View(sorciere);
        }

        // POST: Sorcieres/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom,Origine")] Sorciere sorciere)
        {
            if (id != sorciere.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sorciere);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SorciereExists(sorciere.Id))
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
            return View(sorciere);
        }

        // GET: Sorcieres/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

            return View(sorciere);
        }

        // POST: Sorcieres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Sorcieres == null)
            {
                return Problem("Entity set 'HalloweenContext.Sorcieres'  is null.");
            }
            var sorciere = await _context.Sorcieres.FindAsync(id);
            if (sorciere != null)
            {
                _context.Sorcieres.Remove(sorciere);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SorciereExists(int id)
        {
          return (_context.Sorcieres?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
