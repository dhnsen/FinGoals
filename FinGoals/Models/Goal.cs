using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinGoals.Models
{
    public class Goal
    {
        [Required]
        public ApplicationUser User { get; set; }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public Decimal Amount { get; set; }

        public DateTime DueDate { get; set; }

        public bool IsActive { get; set; } = true;
        
    }
}