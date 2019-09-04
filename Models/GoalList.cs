using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using FinGoals.Data;
using FinGoals.Models;
using Microsoft.AspNetCore.Authorization;

namespace FinGoals.Models
{
    public class GoalList
    {
        private static string userId;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public static IEnumerable<Goal> GetGoals()
        {
            IQueryable<Goal> goals = _context.Goals
                .Where(g => g.UserId == userId);
            return goals;
        }
    }
}
