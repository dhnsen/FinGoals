using FinGoals.Models;
using FinGoals.ViewModels;
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

        // GET: goals
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.PostMessage = "";
            var viewModel = new GoalFormViewModel
            {

            };
            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GoalFormViewModel viewModel)
        {
            ViewBag.PostMessage = "";
            if (!ModelState.IsValid)
            {
                ViewBag.PostMessage = "Save Failed";
                return View("Create", viewModel);
            }
            var context = new ApplicationDbContext();
            var goal = new Goal
            {
                ApplicationUserId = User.Identity.GetUserId(),
                Name = viewModel.Name,
                Amount = viewModel.Amount,
                DueDate = viewModel.DueDate,
                Description = viewModel.Description

            };

            context.Goals.Add(goal);
            context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public ActionResult MyGoals()
        {
            var userId = User.Identity.GetUserId();
            var context = new ApplicationDbContext();
            var upcomingGoals = context.Goals
                .Where(g => g.ApplicationUserId == userId)
                ;
            return View(upcomingGoals);
        }
    }
}
