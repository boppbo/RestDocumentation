using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(CustomizedHelppage.HelpPageRouteConfig), "Start")]

namespace CustomizedHelppage
{
    public static class HelpPageRouteConfig
    {
        public static void Start()
        {
            AreaRegistration.RegisterAllAreas();

            RouteTable.Routes.MapRoute(
                name: "Default_Help",
                url: "",
                defaults: new { controller = "Redirect", action = "Index" }
            );
        }
    }
}
