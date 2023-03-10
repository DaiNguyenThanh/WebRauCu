using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProjectCuoiki
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Default", action = "Index", id = UrlParameter.Optional }
            );
            //routes.MapRoute("News", "{type}/{meta}",
            //    new { Controller = "News", action = "Index", meta = UrlParameter.Optional },
            //    new RouteValueDictionary
            //    {
            //        {"type","tin-tuc" }
            //    },
            //    new[] {"ProjectCuoiKi.Controllers"}
            //    );
        }
    }
}
