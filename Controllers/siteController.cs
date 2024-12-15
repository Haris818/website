using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace website.Controllers
{
    public class siteController : Controller
    {
        // GET: site
        public ActionResult HOME()
        {
            return View();

        }
        public ActionResult SINGUP()
        {
            return View();
        }
        public ActionResult CATEGORIES()
        {
            return View();
        }
        public ActionResult ABOUT()
        {
            return View();
        }
        public ActionResult CONTACT()
        {
            return View();
        }
    }
}