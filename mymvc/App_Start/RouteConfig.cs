using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace mymvc
{
    public class RouteConfig
    {   
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            var route = routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                //constraints: new{id=@"\d+"},
                //namespaces: new[] { "mymvc.Controllers" }// value should 
            );
            //route.DataTokens["UseNamespaceFallback"] = false;
        }
    }
}
