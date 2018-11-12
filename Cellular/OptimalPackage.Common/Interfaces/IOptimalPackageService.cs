using Cellular.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace OptimalPackage.Common.Interfaces
{
    public interface IOptimalPackageService
    {
        Package GetBestPackageOf(int lineId);
    }
}
