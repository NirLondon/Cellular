﻿using Cellular.Common.DTOs;
using Cellular.CRM.Common.Interfaces;
using Cellular.CRM.Common.Models;
using System;

namespace CRM.Bl
{
    public class ClientManager : IClientsManager
    {
        private readonly IClientsRepository _clientsRepository;

        public ClientManager(IClientsRepository clientsRepository)
        {
            _clientsRepository = clientsRepository;
        }
        public AddingClientResult AddNewClient(Client client)
        {
            return _clientsRepository.AddNewClient(client);
        }

        public bool DeleteClient(int clientId)
        {
            throw new NotImplementedException();
        }

        public bool EditClient(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
