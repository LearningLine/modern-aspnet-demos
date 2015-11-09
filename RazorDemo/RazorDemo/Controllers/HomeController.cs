using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RazorDemo.Models;

namespace RazorDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(Products);
        }

        public ActionResult Test()
        {
            return View();
        }
        public ActionResult OnSale()
        {
            return View(Products);
        }

        IEnumerable<Product> Products
        {
            get
            {
                yield return new Product {Name = "iPad"};
                yield return new Product {Name = "iPod"};
                yield return new Product {Name = "iPhone"};
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}