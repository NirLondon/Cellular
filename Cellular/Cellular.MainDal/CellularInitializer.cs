using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellular.MainDal
{
     class CellularInitializer: DropCreateDatabaseAlways<CellularContext>
    {
        protected override void Seed(CellularContext context)
        {
            base.Seed(context);
        }
    }
}
