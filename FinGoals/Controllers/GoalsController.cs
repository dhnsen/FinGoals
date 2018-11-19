using FinGoals.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinGoals.Controllers
{
    [Authorize]
    public class GoalsController : Controller
    {

        private ApplicationDbContext _context;

        public GoalsController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Create()
        {


            return View();
        }
        [HttpPost]
        public ActionResult Create(Goal formGoal)
        {
            var userId = User.Identity.GetUserId();
            var goal = new Goal
            {
                User = _context.Users.Single(u => u.Id == userId),
                DueDate = formGoal.DueDate,
                Amount = formGoal.Amount,
                Name = formGoal.Name
            };
            _context.Goals.Add(goal);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}