using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AuctionSystem
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{role}/{controller}/{action}/{id}",
                defaults: new { role = "User", controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Admin",
                url: "{role}/{controller}/{action}/{id}",
                defaults: new { role = "Admin", controller = "HomeAdmin", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
