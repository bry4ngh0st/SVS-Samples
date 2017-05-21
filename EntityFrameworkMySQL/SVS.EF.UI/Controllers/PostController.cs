using SVS.EF;
using SVS.EF.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace SVS.EF.UI.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        public ActionResult Index()

        {
           // ViewBag. ="Lista Post";

            ///var ConntextoBd = new ContextoBD();
            ///
            var litaPost = new ManagerBD();
           var datosPost= litaPost.ListaPost();

            //string cadena="";
            //foreach (var item in datosPost)
            //{
            //    cadena += "Id: " + item.Id + "Contenido : " + item.Contenido;
            //}
            //ViewBag.Datos = cadena;
            return View(datosPost);
        }
    }
}