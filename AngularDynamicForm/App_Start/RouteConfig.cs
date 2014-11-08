using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AngularDynamicForm
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Form",
                url: "Form",
                defaults: new { controller = "Home", action = "Index" }
            );
            routes.MapRoute(
                name: "SavedForm",
                url: "SavedForm",
                defaults: new { controller = "Home", action = "Index" }
            );
            routes.MapRoute(
                name: "FormList",
                url: "FormList",
                defaults: new { controller = "Home", action = "Index" }
            );
            routes.MapRoute(
                name: "ResponseList",
                url: "ResponseList",
                defaults: new { controller = "Home", action = "Index" }
            );
            routes.MapRoute(
                name: "EditStructure",
                url: "EditStructure",
                defaults: new { controller = "Home", action = "Index" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Statistic API",
                url: "api/statistic/{action}",
                defaults: new { controller = "Statistic"}
            );
            routes.MapRoute(
                name: "API Default",
                url: "api/{controller}/{id}",
                defaults: new { id = UrlParameter.Optional }
            );
        }
    }
}