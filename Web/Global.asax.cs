using System.Data.Entity.Migrations;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Web.Infrastructure;
using Configuration = Domain.Migrations.Configuration;

namespace Web
{
    public class MvcApplication : HttpApplication
    {
        private static IWindsorContainer _container;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            UpdateDb();

            //Set up dependency inection and register custom controller factory
            SetupIOC();
        }

        private void SetupIOC()
        {
            _container = new WindsorContainer();
            _container.Install(FromAssembly.This());

            var controllerFactory = new WindsorControllerFactory(_container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
            GlobalConfiguration.Configuration.DependencyResolver = 
                new Infrastructure.DependencyResolver(_container.Kernel);
        }

        private static void UpdateDb()
        {
            var settings = new Configuration();
            var migrator = new DbMigrator(settings);

            migrator.Update();
        }
    }
}
