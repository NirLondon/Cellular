using System;
using System.Collections.Generic;
using System.Text;

namespace Cellular.Common.DTOs
{
    public class Payment
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public double TotalPrice { get; set; }
        public DateTime Month { get; set; }
    }
}
