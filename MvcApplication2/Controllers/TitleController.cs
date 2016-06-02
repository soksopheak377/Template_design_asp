using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class TitleController : Controller
    {
        //
        // GET: /Title/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            // ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult DataGride()
        {
            // ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}
