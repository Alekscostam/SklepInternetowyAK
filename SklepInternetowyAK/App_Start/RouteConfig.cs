using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SklepInternetowyAK
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "FilmsList",
                url: "stronyFilmy/{categoryName}",
                defaults: new { controller = "Films", action = "List" }
            );

            routes.MapRoute(
                name: "StaticSite",
                url: "strony/{name}",
                defaults: new { controller = "Home", action = "StaticSite", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Regulations",
                url: "strony/{name}",
                defaults: new { controller = "Home", action = "Regulations", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Contact",
                url: "strony/{name}",
                defaults: new { controller = "Home", action = "Contact", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "PaymentMethods",
                url: "strony/{name}",
                defaults: new { controller = "Home", action = "PaymentMethods", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
           
        }
    }
}
