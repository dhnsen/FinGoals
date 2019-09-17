using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinGoals.Data;
using FinGoals.Models;
using Microsoft.AspNetCore.Authorization;

namespace FinGoals.Controllers
{
    [Authorize]
    public class GoalsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public GoalsController(ApplicationDbContext context,
            UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Goals
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            // get a user manager and the id of the current user
            var user = await _userManager.GetUserAsync(HttpContext.User);
            string id = user.Id;

            //get the savings amount of the current user
            var savingsAmount = new SavingsAmount();
            var userSavingsAmount = savingsAmount.GetSavingsAmount(id);
            
            if (_context.Goals.Where(g => g.UserId == user.Id).Count() == 0)
            {
                // Create a new Goal if collection is empty,
                // which means you can't delete all Goals.
                _context.Goals.Add(
                    new Goal
                    {
                        UserId = user.Id,
                        Name = "Emergency Fund, your 1st goal",
                        Amount = 1000.00,
                        Description = "One of the most important things to save for is an emergency. This is recommended as a first step."
                    }
                    );
                _context.SaveChanges();
            }
            GoalIndexViewModel viewModel = new GoalIndexViewModel
            {
                UserTotalSavings = savingsAmount.Amount,
                Goals = _context.Goals
                .Where(g => g.UserId == user.Id)

            };

            return View(viewModel);
        }

        // GET: Goals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Goals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,Name,Amount,Description,IsComplete")] Goal goal)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            if (ModelState.IsValid)
            {
                goal.UserId = user.Id;
                _context.Add(goal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(goal);
        }

        // GET: Goals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goal = await _context.Goals.FindAsync(id);
            if (goal == null)
            {
                return NotFound();
            }
            return View(goal);
        }

        // POST: Goals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,Name,Amount,Description,IsComplete")] Goal goal)
        {
            if (id != goal.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(goal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GoalExists(goal.Id))
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
            return View(goal);
        }

        // GET: Goals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goal = await _context.Goals
                .FirstOrDefaultAsync(m => m.Id == id);
            if (goal == null)
            {
                return NotFound();
            }

            return View(goal);
        }

        // POST: Goals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var goal = await _context.Goals.FindAsync(id);
            _context.Goals.Remove(goal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GoalExists(int id)
        {
            return _context.Goals.Any(e => e.Id == id);
        }
    }
}
