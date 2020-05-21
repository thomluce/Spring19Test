using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Spring19Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is a sample web site created for MIS4200 using ASP.NET MVC.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Thom Luce";

            return View();
        }
    }
}