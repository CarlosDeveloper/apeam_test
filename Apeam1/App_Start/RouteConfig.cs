﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Apeam1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Sale", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "venta",
                url: "{controller}/{action}",
                defaults: new { controller = "Sale", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
