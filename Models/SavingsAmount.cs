using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinGoals.Models
{
    public class SavingsAmount
    {
        // NOTE: the ID is going to be the ID of the user
        // Each user will only have one.
        [Key]
        public string Id { get; set; }
        public double Amount { get; set; }

        public static implicit operator SavingsAmount(int v)
        {
            throw new NotImplementedException();
        }
    }
}
