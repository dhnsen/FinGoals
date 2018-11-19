using FinGoals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinGoals.Controllers
{
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
    }
}