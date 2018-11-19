using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cellular.MainDal.EntityFramework.Entities
{
    public class PackageInclud
    {
        public int ID { get; set; }

        public float Price { get; set; }

        public int PackageID { get; set; }
        public Package Package { get; set; }
    }
}
