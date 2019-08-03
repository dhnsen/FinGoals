using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinGoals.Data;
using FinGoals.Models;

namespace FinGoals.Controllers
{
    public class SavingsAmountsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SavingsAmountsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SavingsAmounts/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var savingsAmount = await _context.SavingsAmounts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (savingsAmount == null)
            {
                return NotFound();
            }

            return View(savingsAmount);
        }

        // GET: SavingsAmounts/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var savingsAmount = await _context.SavingsAmounts.FindAsync(id);
            if (savingsAmount == null)
            {
                return NotFound();
            }
            return View(savingsAmount);
        }

        // POST: SavingsAmounts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Amount")] SavingsAmount savingsAmount)
        {
            if (id != savingsAmount.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(savingsAmount);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SavingsAmountExists(savingsAmount.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", "GoalsController");
            }
            return View(savingsAmount);
        }

        private bool SavingsAmountExists(string id)
        {
            return _context.SavingsAmounts.Any(e => e.Id == id);
        }
    }
}
