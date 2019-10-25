using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ChessResult.Core.Services;
using Fanex.Data;
using Fanex.Data.Repository;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
namespace ChessResult.Site
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static Container container;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            RegisterInstances();

            DbSettingProviderManager
              .StartNewSession()
              .UseDefaultConnectionStringProvider()
              .UseDefaultDbSettingProvider(
                resourcePath: "~/App_Data/SPs",
                ignoreRedundantParameters: false,
                enableWatching: true)
              .Run();
        }

        private void RegisterInstances()
        {
            container = new Container();
            container.Register<IDynamicRepository, DynamicRepository>(Lifestyle.Singleton);
            container.Register<ITournamentService, TournamentService>(Lifestyle.Singleton);
            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}
