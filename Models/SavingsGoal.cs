using System;
using System.ComponentModel.DataAnnotations;

namespace FinGoals.Models
{
    public class SavingsGoal
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }
    }
}