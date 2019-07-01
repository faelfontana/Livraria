using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LivrariaFontana.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "TESTE";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = " OUTRO TESTE";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "MAIS TESTE";

            return View();
        }
    }
}
