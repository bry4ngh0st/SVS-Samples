using SVS.EF.Negocio;
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
            var item = new ManagerBD();
            var posts = item.ListaPosts();
            //string cadena = "";

            //foreach (var lista in posts)
            //{
            //    cadena += lista.Id + " " + lista.Contenido;  
            //}

            //ViewBag.Datos = cadena;

            return View(posts);
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

    }
}