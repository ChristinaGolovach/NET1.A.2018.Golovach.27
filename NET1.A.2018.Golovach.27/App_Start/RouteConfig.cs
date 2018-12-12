using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using NET1.A._2018.Golovach._27.Infrastructure.CustomHttpHandlers;
using NET1.A._2018.Golovach._27.Infrastructure.CustomRouteHandlers;

namespace NET1.A._2018.Golovach._27
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //For Task 1
            //routes.IgnoreRoute("Image/{*path}");

            //For Task 2
            routes.Add(new Route("image/{id}", new ImageRouteHandler()));
     

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
