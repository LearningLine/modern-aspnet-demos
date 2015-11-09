using System.Web.Mvc;

namespace MyFirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /// 1 Get data
            
            var restaurants = new[] { "5 guys", "Jimmy Jons", "Chipotle" };
            //ViewBag.Restaurants = restaurants;
            ViewBag.Something = "hello, this is cool";
            ViewData.Model = restaurants;
            var defaultRestaurant = "5 guys";
            /// 2 Render data
            //return new ContentResult() {Content="Hello"};
            return View(restaurants);
        }

        public ActionResult Help()
        {
            return View();
        }
        
    }
}