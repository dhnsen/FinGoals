using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinGoals.Models
{
    public class GoalIndexViewModel
    {
        public double UserTotalSavings { get; set; }

        public IEnumerable<Goal> Goals { get; set; }
    }
}
