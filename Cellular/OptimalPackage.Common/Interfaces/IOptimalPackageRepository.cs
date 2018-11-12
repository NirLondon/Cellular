using Cellular.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace OptimalPackage.Common.Interfaces
{
    public interface IOptimalPackageRepository
    {
        IEnumerable<Call> GetCallsOf(int lineId, DateTime from, DateTime to);

        IEnumerable<Sms> GetSmsesOf(int lineId, DateTime from, DateTime to);
    }
}
