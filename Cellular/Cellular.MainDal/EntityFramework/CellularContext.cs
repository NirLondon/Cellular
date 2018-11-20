using Cellular.MainDal.EntityFramework.Entities;
using System;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("MainDAL.Tests")]
namespace Cellular.MainDal
{

    public class CellularContext : DbContext
    {
        public CellularContext() : base("name=Cellular")
        {
            Database.SetInitializer(new CellularInitializer());
        }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientType> ClientTypes { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Line> Lines { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Call> Calls { get; set; }
        public virtual DbSet<SMS> SMSes { get; set; }
        public virtual DbSet<RegisrationDetails> Regisrations { get; set; }
    }

}