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
                db.Clients.Add(client);
                db.SaveChanges();
                return new AddingClientResult(client);
            }
            //CellularContext cellularContext = null;
            //try
            //{
            //    cellularContext = new CellularContext();
            //    cellularContext.Clients.Add(client);
            //    cellularContext.SaveChanges();
            //    return new AddingClientResult(client);
            //}
            //catch (Exception)
            //{
            //    throw;
            //}

            //finally
            //{
            //    cellularContext.Dispose();
            //}
          
        }

        public bool DeleteClient(int clientId)
        {
            throw new NotImplementedException();
        }

        public bool EditClient(Cellular.Common.DTOs.Client client)
        {
            throw new NotImplementedException();
        }
    }
}
