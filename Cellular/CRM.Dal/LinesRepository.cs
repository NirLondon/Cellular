using Cellular.Common.DTOs;
using Cellular.CRM.Common.Interfaces;
using Cellular.MainDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Dal
{
    public class LinesRepository : ILinesRepository
    {
        public Package SavePackageToDb(Package package)
        {
            using (var db = new CellularContext())
            {
                
            }
        }
    }
}
