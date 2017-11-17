using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VirtualAssistant
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //use this custom route
            routes.MapMvcAttributeRoutes();

            //custom route-->not very proper to use like this if the system grows
            //routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "movies/released/{year}/{month}",
            //    new { controller = "Movies", action = "ByreleasedDate" },
            //    new { year = @"\d{4}",month = @"\d{2}"});

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
