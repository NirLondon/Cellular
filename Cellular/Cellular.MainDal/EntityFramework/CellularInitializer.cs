using Cellular.MainDal.EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellular.MainDal
{
    class CellularInitializer : DropCreateDatabaseIfModelChanges<CellularContext>
    {
        protected override void Seed(CellularContext context)
        {
            context.ClientTypes.AddRange(new[] {
                new ClientType
                {
                    ID = ClientTypeEnum.Private,
                    CallMinuetePrice = 0.3f,
                    SMSPrice = 0.2f
                },
                new ClientType
                {
                    ID = ClientTypeEnum.Business,
                    CallMinuetePrice = 0.2f,
                    SMSPrice = 0.15f
                },
                new ClientType
                {
                    ID = ClientTypeEnum.VIP,
                    CallMinuetePrice = 0.1f,
                    SMSPrice = 0.08f,
                }
            });

            var emp = new Employee
            {
                ID = 313327215,
                FirstName = "Nir",
                LastName = "London",
                Password = "123456"
            };

            var client  = new Client
            {
                ID = 123456789,
                ClientTypeID = ClientTypeEnum.Private,
                FirstName = "Itamar",
                LastName = "Daisy",
                Password = "123456",
            };

            var pack = new Package
            {
                
            };

            var minBan = new MinutesBank
            {
                Package = pack,
                MaxMinutes = 200,
                Price = 25
            };

            var line1 = new Line
            {
                Client = client,
                Number = "0523852286",
                Package = pack
            };

            var line2 = new Line
            {
                Client = client,
                Number = "0523852286",
                Package = pack
            };

            var reg = new RegisrationDetails
            {
                Client = client,
                Registrator = emp,
                Date = DateTime.Now - TimeSpan.FromDays(100),
            };

            context.Regisrations.Add(reg);

            context.Clients.Add(client);

            context.Employees.Add(emp);

            context.SaveChanges();
        }
    }
}
