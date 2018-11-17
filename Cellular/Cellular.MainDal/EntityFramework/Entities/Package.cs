using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellular.MainDal.EntityFramework.Entities
{
    class Package
    {
        public int ID { get; set; }

        public int MaxMinutes { get; set; }

        public int MaxSMSes { get; set; }

        public float TotalPrice { get; set; }
    }
}
