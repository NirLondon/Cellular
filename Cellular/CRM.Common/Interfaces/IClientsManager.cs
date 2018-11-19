using Cellular.Common.DTOs;
using Cellular.CRM.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cellular.CRM.Common.Interfaces
{
    public interface IClientsManager
    {
        Employee LoginEmployee(string identity, string password);
        AddingClientResult AddNewClient(Client client);
        bool EditClient(Client client);
        bool DeleteClient(int clientId);

    }
}
