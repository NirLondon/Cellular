using Cellular.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Invoices.Common.Interfaces
{
    public interface IInvoicesRepository
    {
        Call[] GetCallsOfLine(int lineId, DateTime from, DateTime until);

        Call[] GetCallsOfClient(int clientId);
        Call[] GetCallsOfLine(int lineId);

        Sms[] GetSMSsOfClient(int clientId);
        Sms[] GetSMSesOfLine(int lineId);

        double GetInternetUsageOfClient(int clientId);

        Package GetPackageOf(int lineId);
    }
}
