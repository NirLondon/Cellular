using Bi.Bl;
using Bi.Common.Interfaces;
using Cellular.CRM.Common.Interfaces;
using CRM.Bl;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Cellular.Server
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            // config container and registering

            var clientBlManager = new BlIocManager();
            var reportBlManager = new IocReportsContainer();
            var container = new Container();
            container.Register<IClientsManager>(()=> clientBlManager.GetInstanceOf<ClientManager>());
            container.Register<IReportManager>(() => reportBlManager.GetInstanceOf<ReportManager>());
            container.RegisterMvcControllers();

            // Makes sure that the container configed properly
            container.Verify();
            // Set the app dependency resolver to this container
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}
