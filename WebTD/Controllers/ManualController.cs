using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class ManualController : Controller
    {
        // GET: Manual
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TowerDefense()
        {
            return View();
        }
    }
}