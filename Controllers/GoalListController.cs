using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinGoals.Data;
using FinGoals.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FinGoals.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoalListController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public GoalListController(ApplicationDbContext context,
            UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: api/SavingsAmount
        [Authorize]
        [HttpGet]
        public IEnumerable<Goal> GetGoals()
        {
            var goals = GoalList.GetGoals();

            return goals;
        }
    }
}