using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoftUhi.Ajax.App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ServerTime()
        {
            // Very useful not to access the action from URL
            // The same as [ChildActionOnly]
            if(!Request.IsAjaxRequest())
            {
                return this.HttpNotFound();
            }

            var time = DateTime.Now;

            return this.View(time);
        }

        public ActionResult GetValues()
        {
            var values = Enumerable.Range(1, 10)
                .Select(num => "Value " + num)
                .ToList();
            //  By default for security MVC does not permit GET requests
            return this.Json(values, JsonRequestBehavior.AllowGet);
        }
    }
}