using Cellular.Common.DTOs;
using Cellular.CRM.Common.Interfaces;
using Cellular.CRM.Common.Models;
using Cellular.CRM.Common.Enums;
using Cellular.MainDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CRM.Dal
{
    public class ClientRepository : IClientsRepository
    {
       
        public AddingClientResult AddNewClient(Client client)
        {
            using (var db = new CellularContext())
            {
                if (db.Clients.Any(c => c.ClientId == client.ClientId))
                {
                    return new AddingClientResult(AddingClientFailureReason.ClientAlreadyExist);
                }
                
                db.Clients.Add(client);
                db.SaveChanges();
                return new AddingClientResult(client);
            }
        
          
        }

        public bool DeleteClient(int clientId)
        {
            using (var db = new CellularContext())
            {
                var clientRemoved = db.Clients.FirstOrDefault(c => c.ClientId == clientId);
                if (clientRemoved == null)
                {
                    return false;
                }
                else
                {
                    db.Clients.Remove(clientRemoved);
                    db.SaveChanges();
                    return true;
                }
            }
        }

        public bool EditClient(Client client)
        {
            using (var db = new CellularContext())
            {
                var clientEdited = db.Clients.FirstOrDefault(c => c.ClientId == client.ClientId);
                clientEdited.ClientName= 
            }
        }

        public Employee LoginEmployee(string identity, string password)
        {
            using (var db = new CellularContext())
            {
                return db.Employees.FirstOrDefault(e => e.Identity == identity && e.Password == password);
            }
        }
    }
}
