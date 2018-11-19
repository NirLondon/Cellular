using Invoices.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Invoices.DAL
{
    class Repository : IInvoicesRepository
    {
        public Cellular.Common.DTOs.Call[] GetCallsOfClient(int clientId)
        {
            throw new NotImplementedException();
        }

        public global::Cellular.Common.DTOs.Call[] GetCallsOfLine(int lineId, DateTime from, DateTime until)
        {
            throw new NotImplementedException();
        }

        public global::Cellular.Common.DTOs.Call[] GetCallsOfLine(int lineId)
        {
            throw new NotImplementedException();
        }

        public double GetInternetUsageOfClient(int clientId)
        {
            throw new NotImplementedException();
        }

        public global::Cellular.Common.DTOs.Package GetPackageOf(int lineId)
        {
            throw new NotImplementedException();
        }

        public global::Cellular.Common.DTOs.Sms[] GetSMSesOfLine(int lineId)
        {
            throw new NotImplementedException();
        }

        public global::Cellular.Common.DTOs.Sms[] GetSMSsOfClient(int clientId)
        {
            throw new NotImplementedException();
        }
    }
}
