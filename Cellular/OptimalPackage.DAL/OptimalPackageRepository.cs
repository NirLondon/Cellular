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
                return context.Calls.Where(c => c.LineId == lineId && c.CallDate >= from && c.CallDate <= to);
            }
        }

        public IEnumerable<Sms> GetSmsesOf(int lineId, DateTime from, DateTime to)
        {
            using (var contest = new CellularContext())
            {
                return contest.Sms.Where(s => s.LineId == lineId && s.);
            }
        }
    }
}
