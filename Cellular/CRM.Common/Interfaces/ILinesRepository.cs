using System;
using System.Collections.Generic;
using System.Text;
using Cellular.Common.DTOs;

namespace Cellular.CRM.Common.Interfaces
{
    public interface ILinesRepository
    {
        Package SavePackageToDb(Package package);
    }
}
