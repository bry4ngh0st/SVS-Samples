using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SVS.EF.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "MVC";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "nuevo.";

            return View();
        }
    }
}