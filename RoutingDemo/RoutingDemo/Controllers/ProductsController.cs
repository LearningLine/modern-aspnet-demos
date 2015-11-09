using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingDemo.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index(string id, string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return RedirectToAction("Index",
                new {
                    id =id,
                    text = "TextHere"
                })
                ;
            }
            return View(new Product {Id = id, Name = text});
        }
    }

    public class Product
    {
        public string  Id { get; set; }
        public string  Name { get; set; }
    }
}