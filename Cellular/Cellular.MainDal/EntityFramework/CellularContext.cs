namespace Cellular.MainDal
{
    using Cellular.Common.DTOs;
    using System;
    using System.Data.Entity;
    using System.Linq;


    public class CellularContext : DbContext
    {
        public CellularContext()
            : base("name=CellularContext")
        {
            Database.SetInitializer<CellularContext>(new CellularInitializer());
        }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Call> Calls { get; set; }
        public virtual DbSet<ClientType> ClientTypes { get; set; }
        public virtual DbSet<Line> Lines { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<SelectedNumbers> SelectedNumbers { get; set; }
        public virtual DbSet<Sms> Sms { get; set; }

    }

}