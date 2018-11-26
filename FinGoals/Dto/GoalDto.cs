using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinGoals.Dto
{
    public class GoalDto
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public decimal Amount { get; set; }

        public DateTime DueDate { get; set; }

        public string Description { get; set; }
    }
}