using System;
using System.Collections.Generic;
using System.Text;

namespace Cellular.Common.Interfaces
{
    public interface IIocContainer
    {
        T GetInstanceOf<T>() where T : class;
    }
}
