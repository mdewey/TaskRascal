using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskRascal.ViewModels;
using TaskRascal.Models;

namespace TaskRascal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Parent()
        {

            var db = new TRContext();
            // gets dummy user
            //var user = db.UserProfiles.FirstOrDefault(w => w.FamilyRole == FamilyRole.Parent);
            //// get activites
            //var activites = db.Activities.OrderByDescending(o => o.TimeAdded).Take(3);
            
            //// get all tasks
            //var tasks = db.Tasks.OrderBy(o => o.DueDate).Take(3);
            //// get totals
            //var tasksCompletes = db.Tasks.Count(c => c.IsApproved);
            //var tasksCount = db.Tasks.Count();
            //// init view models
            //var vm = new ParentPageData(activites, tasks, user, tasksCompletes, tasksCount);
            return View();
        }


        public ActionResult Child()
        {   

            var db = new TRContext();
            //// gets dummy user
            //var user = db.UserProfiles.FirstOrDefault(w => w.FamilyRole == FamilyRole.Child);
            //// get activites
            //var activites = db.Activities.Where(w => w.ShowForChild).OrderByDescending(o => o.TimeAdded).Take(3);
            //// get goals
            //var goal = db.Goals.OrderBy(o => o.DateAdded).FirstOrDefault();
            //// get tasks
            //var tasks = db.Tasks.Where(w => w.UserId == user.UserId).OrderBy(o => o.DueDate).Take(3);
            //// init view models
            //var vm = new ChildPageData(activites, tasks, goal);
            return View();
        }
    }
}
