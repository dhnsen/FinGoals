using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinGoals.ViewModels
{
    public class GoalFormViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        [DisplayName("Due Date")]
        public DateTime DueDate { get; set; }

        public string Description { get; set; }
    }
}