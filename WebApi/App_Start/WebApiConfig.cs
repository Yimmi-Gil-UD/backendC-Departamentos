using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Net.Http.Headers;
using System.Web.Http.Cors;

namespace WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html")); // retornar Json

            // para permitir solicitudes de cualquier parte, primero instalar lo siguiente por consola:
            // Install-Package Microsoft.AspNet.WebApi.cors
            //luego la siguiente linea :
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));

        }
    }
}
