using Cellular.CRM.Common.Interfaces;
using CRM.Bl;
using CRM.Dal;
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
            var container = new Container();
            container.Register<IClientsManager, ClientManager>();
            container.Register<IClientsRepository, ClientRepository>();
            container.RegisterMvcControllers();

            // Makes sure that the container configed properly
            container.Verify();
            // Set the app dependency resolver to this container
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}
