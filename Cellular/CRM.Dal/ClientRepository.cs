using Cellular.Common.DTOs;
using Cellular.CRM.Common.Interfaces;
using Cellular.CRM.Common.Models;
using Cellular.CRM.Common.Enums;
using Cellular.MainDal;
using Cellular.MainDal.ModelConverters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cellular.MainDal.EntityFramework.Entities;

namespace CRM.Dal
{
    public class ClientRepository : IClientsRepository
    {
        public AddingClientResult AddNewClient(Cellular.Common.DTOs.Client client)
        {
            using (var db = new CellularContext())
            {
                if (db.Clients.Any(c => c.ID == client.ClientId))
                {
                    return new AddingClientResult(AddingClientFailureReason.ClientAlreadyExist);
                }
                
                db.Clients.Add(client.ToEntity());
                db.SaveChanges();
                return new AddingClientResult(client);
            }
        
          
        }

        //public bool DeleteClient(int clientId)
        //{
        //    using (var db = new CellularContext())
        //    {
        //        var clientRemoved = db.Clients.FirstOrDefault(c => c.ID == clientId);
        //        if (clientRemoved == null)
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            db.SaveChanges();
        //            return true;
        //        }
        //    }
        //}

        public bool EditClient(Cellular.Common.DTOs.Client client)
        {
            using (var db = new CellularContext())
            {
                var clientEdited = db.Clients.FirstOrDefault(c => c.ID == client.ClientId);
                if (clientEdited == null)
                {
                    return false;
                }
                clientEdited.Password = client.Password;
                clientEdited.ClientTypeID = (ClientTypeEnum)Enum.Parse(typeof(ClientTypeEnum),client.ClientTypeId);
                clientEdited.EmailAddress = client.EmailAddress;
                clientEdited.FirstName = client.FirstName;
                clientEdited.LastName = client.LastName;
                clientEdited.Identity = client.Identity;
                return true;

            }
        }

        public Cellular.Common.DTOs.Employee LoginEmployee(string identity, string password)
        {
            using (var db = new CellularContext())
            {
                var employeLogged= db.Employees.FirstOrDefault(e => e.Identity == identity && e.Password == password);

                try
                {
                    return employeLogged.ToCommon();
                }
                catch (Exception ex)
                {
                    throw new Exception("The username or the password isn't correct");
                }
            }
        }

       
    }
}
