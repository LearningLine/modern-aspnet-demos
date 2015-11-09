using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using Routing2demo.Models;

namespace Routing2demo.Controllers
{
    public class ProductsController: Controller
    {
        
        public ActionResult Index(string id)
        {
           
            if (id == null)
                return View("AllProducts", Products);
            var product = Products.First(x => x.Id == id);
            return View(model: product);

        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            var p = Products.Single(x => x.Id == id);
            return View(p);
        }

        public ActionResult Documentation(string id)
        {
            return File(@"C:\temp\test.txt",
                "text/plain");
        }
        public ActionResult Json(string id)
        {
            var p = Products.FirstOrDefault(x => x.Id == id);
            if (p == null)
                return HttpNotFound("no product");
            return Json(p, JsonRequestBehavior.AllowGet);

        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(string id, string text)
        {
            var p = Products.SingleOrDefault(x => x.Id == id);
            if (p == null)
                HttpNotFound("no product");
            p.Name = text;
            return RedirectToAction(nameof(Index), new {id});
            return new RedirectToRouteResult("Index", new RouteValueDictionary());
            return Redirect("/products/index/" + id);
        }
        ////DEMO ONLY, don't do that in real code
        static List<Product> Products = new List<Product>
        {
            new Product {Id="1", Name="Light saber" },
            new Product {Id="2", Name="R2D2" },
            new Product {Id="3", Name="C3PO" },
        };
    }
}