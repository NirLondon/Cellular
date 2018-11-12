namespace Cellular.MainDal
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CellularContext : DbContext
    {
        public CellularContext()
            : base("name=CellularContext")
        {

        }

    }

}