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
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "ご意見・お問い合わせ";

            return View();
        }

        public ActionResult GameSelection()
        {
            ViewBag.Message = "ゲームを選択してください：";

            return View();
        }



    }

}