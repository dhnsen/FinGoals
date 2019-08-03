using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinGoals.Data;
using FinGoals.Models;

namespace FinGoals.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SavingsAmountController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SavingsAmountController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/SavingsAmount
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SavingsAmount>>> GetSavingsAmounts()
        {
            return await _context.SavingsAmounts.ToListAsync();
        }

        // GET: api/SavingsAmount/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SavingsAmount>> GetSavingsAmount(string id)
        {
            var savingsAmount = await _context.SavingsAmounts.FindAsync(id);

            if (savingsAmount == null)
            {
                return NotFound();
            }

            return savingsAmount;
        }

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

        // POST: api/SavingsAmount
        [HttpPost]
        public async Task<ActionResult<SavingsAmount>> PostSavingsAmount(SavingsAmount savingsAmount)
        {
            _context.SavingsAmounts.Add(savingsAmount);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSavingsAmount", new { id = savingsAmount.Id }, savingsAmount);
        }

        // DELETE: api/SavingsAmount/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SavingsAmount>> DeleteSavingsAmount(string id)
        {
            var savingsAmount = await _context.SavingsAmounts.FindAsync(id);
            if (savingsAmount == null)
            {
                return NotFound();
            }

            _context.SavingsAmounts.Remove(savingsAmount);
            await _context.SaveChangesAsync();

            return savingsAmount;
        }

        private bool SavingsAmountExists(string id)
        {
            return _context.SavingsAmounts.Any(e => e.Id == id);
        }
    }
}
