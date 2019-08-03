using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinGoals.Data;
using FinGoals.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace FinGoals.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SavingsAmountController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public SavingsAmountController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }

        // GET: api/SavingsAmount
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<SavingsAmount>> GetSavingsAmount()
        {
            // get Id of current user
            // What does Identity do? NO ONE KNOWS!
            // Are you ready for the magic??
            var user = await _userManager.GetUserAsync(HttpContext.User);
            string id = user.Id;

            // get savingsAmount if there is one
            var savingsAmount = await _context.SavingsAmounts.FindAsync(id);

            // if there isn't, make one and save it
            if (savingsAmount == null)
            {
                savingsAmount = new SavingsAmount()
                {
                    Id = id,
                    Amount = 0
                };
                _context.Add(savingsAmount);
                _context.SaveChanges();
            }
            return savingsAmount;
        }

        [Authorize]
        // PUT: api/SavingsAmount/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSavingsAmount(string id, SavingsAmount savingsAmount)
        {
            if (id != savingsAmount.Id)
            {
                return BadRequest();
            }

            _context.Entry(savingsAmount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SavingsAmountExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool SavingsAmountExists(string id)
        {
            return _context.SavingsAmounts.Any(e => e.Id == id);
        }
    }
}
