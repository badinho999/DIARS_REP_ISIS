using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CapaPresentacion
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "GenerarCPReserva",
                "{controller}/{action}/{id}/{monto}/{tax}/{shipping}",
                new { controller = "CreatePayment", action = "PayPal" }
                );

            routes.MapRoute(
                "RealizarReserva",
                "{controller}/{action}/{id}/{fechaReserva}/{fechaIngreso}/{fechaSalida}/{cantidadAdultos}/{cantidadKids}",
                new { controller = "RealizarReserva", action = "RealizarReserva" }
                );

            routes.MapRoute(
                "RealizarAlquiler",
                "{controller}/{action}/{id}/{dni}/{fechaIngreso}/{fechaSalida}/{cantidadAdultos}/{cantidadKids}",
                new {controller = "RealizarAlquiler",action = "RealizarAlquiler" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Menu", action = "Inicio", id = UrlParameter.Optional }
            );
        }
    }
}
