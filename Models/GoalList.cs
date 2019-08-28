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
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        
        public async Task<IEnumerable<Goal>> GetGoals(string userId) 
        { 
            var goals = _context.Goals
                .Where(g => g.UserId == userId);
            return goals;
        }
    }
}
