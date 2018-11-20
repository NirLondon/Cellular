using Cellular.Common.DTOs;
using Cellular.CRM.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cellular.CRM.Common.Interfaces
{
    public interface IClientsRepository
    {
        AddingClientResult AddNewClient(Client client);
        bool EditClient(Client client);
        Employee LoginEmployee(string identity,string password);
    }
}
