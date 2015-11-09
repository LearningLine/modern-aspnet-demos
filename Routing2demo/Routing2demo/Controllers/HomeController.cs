using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routing2demo.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public ActionResult Index()
        {
            return View(model:Id);
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