using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FinGoals.Data;

namespace FinGoals.Models
{
    public class SavingsAmount
    {
        // NOTE: the ID is going to be the ID of the user
        // Each user will only have one.
        [Key]
        public string Id { get; set; }
        public double Amount { get; set; }

        private readonly ApplicationDbContext _context;

        public async Task<SavingsAmount> GetSavingsAmount(string id)
        {
            
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
    }
}
