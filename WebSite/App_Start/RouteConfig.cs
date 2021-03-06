﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebSite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Catalog",
                url: "music/albums/catalog",
                defaults: new { controller = "Catalog", action = "Index" }
            );

            routes.MapRoute(
                name: "Album",
                url: "music/album/{albumId}",
                defaults: new { controller = "Catalog", action = "Album", albumId = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Catalog", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}