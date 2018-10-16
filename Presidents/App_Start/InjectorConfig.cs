using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using BLL;
using DTO;

using System.Web.Http;
using SimpleInjector.Integration.WebApi;

namespace Presidents.App_Start
{
    public class InjectorConfig
    {
        public static void RegisterComponents()
        {
            var container = new Container();
            container.Register<IOperations<President>, BLLPresident>();
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
            container.Verify();
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}