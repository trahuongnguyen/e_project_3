using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuctionSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Checkout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Cart()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Detail()
        {
            return View();
        }

        public ActionResult Interest()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }

        public ActionResult Sell_an_item()
        {
            return View();
        }

        public ActionResult Shop()
        {
            return View();
        }
    }
}