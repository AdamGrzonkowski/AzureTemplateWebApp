using Autofac;
using Autofac.Integration.Mvc;
using Helper.Common.Configuration;
using Helper.Common.Http;
using System.Web.Mvc;

namespace App.App_Start.IoC
{
    public class Container
    {
        public static void Build()
        {
            var builder = new ContainerBuilder();

            // Register your MVC controllers. (MvcApplication is the name of
            // the class in Global.asax.)
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<HttpHandler>().As<IHttpHandler>().SingleInstance();
            builder.RegisterType<Configuration>().As<IConfiguration>().SingleInstance();

            builder.RegisterGeneric(typeof(RestService<>)).As(typeof(IRestService<>)).InstancePerRequest();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}