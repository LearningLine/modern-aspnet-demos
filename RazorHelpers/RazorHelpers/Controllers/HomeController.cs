using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RazorHelpers.Models;

namespace RazorHelpers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string id)
        {
            return View(model:id);
        }

        public ActionResult TestList()
        {
            var games = new SelectListItem[]
            {
                new SelectListItem() {Value = "2", Text = "Halo"}, 
                new SelectListItem() {Value = "3", Text = "Doom", Selected = true}, 
                new SelectListItem() {Value = "4", Text = "Call of duty"}
            };
            var model = new Gamer()
            {
                FirstName = "Tom",
                Level = 9,
                Games =  games,
            };
            return View(model);
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