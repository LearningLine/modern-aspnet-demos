using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RoutingDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute(
                name: "product",
                url: "products/{id}/{text}",
                defaults: new
                {
                    controller = "Products",
                    action = "Index",
                    text = UrlParameter.Optional
                }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}/{text}",
                defaults: new
                {
                    controller = "Home", action = "Index",
                    id = UrlParameter.Optional,
                    text = UrlParameter.Optional
                }
            );

        }
    }
}
