using System;
using System.Collections.Generic;
using System.Text;

namespace Invoices.Common.Interfaces
{
    public interface IInvoicesService
    {
        bool CalculateReceipt(int clientId, Month month);

    }

    public enum Month
    {
        January=1,
        Febuary=2,
        March=3,
        April=4,
        May=5,
        June=6,
        July=7,
        Auguost=8,
        September =9,
        October=10,
        November=11,
        December=12
    }
}
