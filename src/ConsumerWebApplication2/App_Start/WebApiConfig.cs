using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ConsumerWebApplication2
{
    /// <summary>   A web API configuration. </summary>
    public static class WebApiConfig
    {
        /// <summary>   Registers this object. </summary>
        ///
        /// <param name="config">   The configuration. </param>
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
