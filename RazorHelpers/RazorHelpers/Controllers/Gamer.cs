using System.Web.Mvc;

namespace RazorHelpers.Models
{
    public class Gamer
    {


        public string  FirstName { get; set; }
        public int  Level{ get; set; }
        public SelectListItem[]  Games{ get; set; }
    }
}