using Cellular.Common.DTOs;
using Cellular.CRM.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cellular.CRM.Common.Interfaces
{
    public interface IClientsManager
    {
        AddingClientResult AddNewClient(Client client);
        bool EditClient(Client client);
        bool DeleteClient(int clientId);

    }
}
