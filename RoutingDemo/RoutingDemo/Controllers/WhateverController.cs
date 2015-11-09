using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingDemo.Controllers
{
    public class WhateverController : Controller
    {
        // GET: Whatever
        public ActionResult Index()
        {
            return View();
        }
    }
}