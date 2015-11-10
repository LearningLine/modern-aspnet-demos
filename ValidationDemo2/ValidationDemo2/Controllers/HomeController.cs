using System;
using System.Web.Mvc;
using ValidationDemo2.Models;

namespace ValidationDemo2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Update(string id)
        {
            var employee = new Employee() {Id = id, Name = "Tom"};
            return View(employee);
        }
        [HttpPost]
        public ActionResult Update(Employee employee)
        {
            
            if (!ModelState.IsValid)
            {
                return View(employee);
            }

            // UPDATE THE DB

            return RedirectToAction("Index");
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