using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellular.MainDal.EntityFramework.Entities
{
    public class Payment
    {
        public int Id { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public float TotalPrice { get; set; }
        public DateTime Month { get; set; }
    }
}
