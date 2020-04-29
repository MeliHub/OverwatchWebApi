using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;

namespace OverwatchWebAPI
{
    // NEW CLASS FOR CUSTOMIZING A FORMATTER TO JSON
    public class CustomJsonFormatter : JsonMediaTypeFormatter
    {
        public CustomJsonFormatter()
        {
            this.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));
           
        }
        public override void SetDefaultContentHeaders(Type type, HttpContentHeaders headers, MediaTypeHeaderValue mediaType)
        {
            base.SetDefaultContentHeaders(type, headers, mediaType);
            headers.ContentType = new MediaTypeHeaderValue("application/json");
        }
    }
    public static class WebApiConfig
    {
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

            // Registering our custom json formatter
            config.Formatters.Add(new CustomJsonFormatter());

          
            // CHANGING FORMAT TO JSON AND DISABLING XML FORMAT
            // var json = config.Formatters.JsonFormatter;
            // json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
            //config.Formatters.Remove(config.Formatters.XmlFormatter);

            //
            // When the header is html we want to return json format
            //config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));
        }
    }
}
