using Cellular.Common.DTOs;
using Cellular.MainDal;
using OptimalPackage.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OptimalPackage.DAL
{
    class OptimalPackageRepository : IOptimalPackageRepository
    {
        public IEnumerable<Call> GetCallsOf(int lineId, DateTime from, DateTime to)
        {
            using (var context = new CellularContext())
            {
                return context.Calls.Where(c => c.LineId==lineId&& c.)
            }
        }

        public IEnumerable<Sms> GetSmsesOf(int lineId, DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }
    }
}
