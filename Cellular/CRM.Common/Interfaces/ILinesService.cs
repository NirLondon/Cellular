using Cellular.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cellular.CRM.Common.Interfaces
{
    interface ILinesService
    {
        // to be continued
        Line AddLine(int clientId, Package package);
        bool EditLine(int lineId, Package newPackage);
        bool RemoveLine(int lineId);
    }
}
