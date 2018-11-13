using Cellular.CRM.Common.Interfaces;
using CRM.Dal;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Bl
{
    public class BlIocManager
    {
        private Container _container;

        public BlIocManager()
        {
            _container = new Container();
            _container.Register<IClientsRepository, ClientRepository>();
            _container.Register<ClientManager>();

            _container.Verify();

        }

        public T GetInstanceOf<T>()where T: class
        {
            return _container.GetInstance<T>();
        }


    }
}
