using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace mvc_projeto.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //cria objeto do tipo cliene e chama a função
            //salva em um viebag de nome cliente
           // ViewBag.cliente = new Cliente().nomes();
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
    }
}