using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellular.MainDal.EntityFramework.Entities
{
    public class Package
    {
        public int ID { get; set; }

        public  List<PackageInclud> PackageIncluds { get; set; }
    }
}
