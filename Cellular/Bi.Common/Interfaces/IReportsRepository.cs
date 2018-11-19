using Cellular.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bi.Common.Interfaces
{
    public interface IReportsRepository
    {
        List<Client> GetMostValueClients();
        List<Client> GetMostCallingToCenterClients();
        List<Employee> GetBestEmployees();
        List<Client> GetPotentialGroup();
    }
}
