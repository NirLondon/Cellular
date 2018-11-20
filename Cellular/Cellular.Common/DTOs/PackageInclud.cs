using System;
using System.Collections.Generic;
using System.Text;

namespace Cellular.Common.DTOs
{
    public class PackageInclud
    {
        public int ID { get; set; }

        public float Price { get; set; }

        public int PackageID { get; set; }
        public Package Package { get; set; }
    }
}
