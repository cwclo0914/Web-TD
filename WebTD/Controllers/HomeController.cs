using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "経緯";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "ご意見・お問い合わせ";

            return View();
        }

        public ActionResult GameSelection()
        {
            ViewBag.Message = "以下から選択してください：";

            return View();
        }



    }

}