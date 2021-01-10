using Microsoft.Owin.Cors;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using System.Web.Http;
using MS.Challenge.Services.API.Helpers;
using MS.Challenge.CrossCutting.IOC;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Owin;


namespace MS.Challenge.Services.API
{
    public class Startup
    {
        public static UnityContainer Container { get; set; }

        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            Container = new UnityContainer();

            ConfigureWebApi(config);
            ConfigureDependencyInjection(config, Container);

            app.UseCors(CorsOptions.AllowAll);
            app.UseWebApi(config);
        }

        public static void ConfigureWebApi(HttpConfiguration config)
        {
            var formatters = config.Formatters;
            formatters.Remove(formatters.XmlFormatter);
            formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.None;

            var jsonSettings = formatters.JsonFormatter.SerializerSettings;
            jsonSettings.Formatting = Formatting.Indented;
            jsonSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", new { id = RouteParameter.Optional });
        }

        public static void ConfigureDependencyInjection(HttpConfiguration config, UnityContainer container)
        {
            DependencyRegister.Register(container);
            config.DependencyResolver = new UnityResolverHelper(container);
            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(container));
        }
    }
}