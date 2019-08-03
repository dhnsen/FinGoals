using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinGoals.Models
{
    public class SavingsAmount
    {
        [Key]
        public string Id { get; set; }
        public double Amount { get; set; }
    }
}
