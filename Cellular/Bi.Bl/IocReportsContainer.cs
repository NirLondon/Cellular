using Bi.Common.Interfaces;
using Bi.Dal;
using Cellular.Common.Interfaces;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bi.Bl
{
    public class IocReportsContainer : IIocContainer
    {
        private Container _container;

        public IocReportsContainer()
        {
            _container = new Container();
            _container.Register<IReportsRepository, ReportsRepository>();
            _container.Register<ReportManager>();
            _container.Verify();
        }

        public T GetInstanceOf<T>() where T : class
        {
            return _container.GetInstance<T>();
        }
    }
}
