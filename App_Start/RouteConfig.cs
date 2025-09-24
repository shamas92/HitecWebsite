using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Website
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Add specific error routes FIRST
            routes.MapRoute(
                name: "Error404",
                url: "Error/NotFound",
                defaults: new { controller = "Error", action = "NotFound" }
            );

            routes.MapRoute(
                name: "Error500", 
                url: "Error/Index",
                defaults: new { controller = "Error", action = "Index" }
            );

            routes.MapRoute(
                name: "ErrorConstruction",
                url: "Error/UnderConstruction",
                defaults: new { controller = "Error", action = "UnderConstruction" }
            );

            routes.MapRoute(
                name: "ErrorMaintenance",
                url: "Error/Maintenance",
                defaults: new { controller = "Error", action = "Maintenance" }
            );

            routes.MapRoute(
                name: "ErrorAccessDenied",
                url: "Error/AccessDenied",
                defaults: new { controller = "Error", action = "AccessDenied" }
            );

            // Add specific route for Downloads categories
            routes.MapRoute(
                name: "DownloadsCategory",
                url: "Downloads/Category/{categoryName}",
                defaults: new { controller = "Downloads", action = "Category" },
                constraints: new { categoryName = @"^[a-zA-Z]+$" }
            );

            // Add specific route for Downloads
            routes.MapRoute(
                name: "Downloads",
                url: "Downloads",
                defaults: new { controller = "Downloads", action = "Index" }
            );

            routes.MapRoute(
                name: "DownloadsAction",
                url: "Downloads/{action}",
                defaults: new { controller = "Downloads", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            // Catch-all for unmapped MVC routes to avoid IIS-level errors and loops
            routes.MapRoute(
                name: "CatchAllNotFound",
                url: "{*url}",
                defaults: new { controller = "Error", action = "NotFound" }
            );
        }
    }
}
