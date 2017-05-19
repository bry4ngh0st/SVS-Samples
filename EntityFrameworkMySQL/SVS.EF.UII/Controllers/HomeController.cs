using SVS.EF.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SVS.EF.UII.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            ManagerBD manager = new ManagerBD();
            var posts = manager.Listarposts();
            //var cadena="";

            //foreach (var post in posts)
            //{
            //    cadena = cadena + " " +post.Id+" "+post.Contenido+" "+post.FechaRegistro + " " + post.FechaModificacion;
            //}
            //ViewBag.mensaje = cadena;

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
        public ActionResult lista()
        {
            return View();
        }
    }
}