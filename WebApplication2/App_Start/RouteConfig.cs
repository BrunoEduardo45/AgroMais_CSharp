using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                "addservico",
                "addservico",
                new { controller = "Home", action = "addServico" }
            );
            routes.MapRoute(
                "clientes",
                "clientes",
                new {controller = "Home", action = "Clientes"}
            );
            routes.MapRoute(
                "addcliente",
                "addcliente",
                new {controller = "Home", action = "addCliente" }
            );
            routes.MapRoute(
               "configuracao",
               "configuracao",
               new { controller = "Home", action = "Configuracao" }
            );
        }
    }
}
