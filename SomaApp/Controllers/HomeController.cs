using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SomaApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sum(int n1, int n2)
        {
            var total = n1 + n2;
            ViewBag.Message = string.Format("Total da soma: {0}", total);
            return View();
        }
    }
}