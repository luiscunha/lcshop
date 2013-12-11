using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LCShop.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "LC Shop - Index";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "LC Shop - About";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "LC Shop - Contacts";

            return View();
        }
    }
}
