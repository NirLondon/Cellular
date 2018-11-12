using Cellular.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Invoices.Common.Interfaces
{
    public interface ICallsService
    {
        void DocumentCall(Call call);
        void DocumentSms(Sms sms);
    }
}
