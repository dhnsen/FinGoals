using FinGoals.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace FinGoals.Api
{
    public class GoalsController : ApiController
    {
        ApplicationDbContext _context = new ApplicationDbContext();

        // GET api/<controller>
        [Authorize]
        public IEnumerable<Goal> Get()
        {
        //    Goal[] goals = new Goal[]
        //{
        //    new Goal { Id = 1, Name = "Goal1", ApplicationUserId = User.Identity.GetUserId(), Amount = 100.10M, DueDate = DateTime.Now },
        //    new Goal { Id = 1, Name = "Goal2", ApplicationUserId = User.Identity.GetUserId(), Amount = 100.10M, DueDate = DateTime.Now }
        //};
            var userId = User.Identity.GetUserId();
            var goals = _context.Goals
                .Where(g => g.ApplicationUserId == userId && g.IsActive == true)
                .ToList();

            return goals;
        }
    }
}