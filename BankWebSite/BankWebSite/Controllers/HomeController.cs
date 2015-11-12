using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankWebSite.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(balance);
        }
        [ValidateAntiForgeryToken, HttpPost]
        public ActionResult SendMoney(int amount, string recipient)
        {
            balance -= amount;
            return RedirectToAction(nameof(Index));
        }

        private static int balance;

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize(Roles = "Admin")]
        public ActionResult TransferAllTheBankMoneyToAForeignCountry()
        {
            /// bad stuff
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}