using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class TDController : Controller
    {
        // GET: TD
        public ActionResult Index()
        {
            return View(); // cshtml
            //return File("~/Statics/index.html", "text/html"); // static html
        }
    }
}