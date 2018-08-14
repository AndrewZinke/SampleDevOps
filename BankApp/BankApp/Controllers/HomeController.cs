using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankApp.Controllers
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
            ViewBag.AnotherMessage = "Hello There";
            ViewBag.GeneralKenobi = "General Kenobi!";
            return View();
        }

        public ActionResult Customer()
        {
            ViewBag.Message = "Some person";

            return View();
        }
    }
}