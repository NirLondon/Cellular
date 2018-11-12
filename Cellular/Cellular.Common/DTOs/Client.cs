using System;
using System.Collections.Generic;
using System.Text;

namespace Cellular.Common.DTOs
{
    public class Client
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int ClientTypeId { get; set; }
        public string Address { get; set; }
        public int ContactNumber { get; set; }
        public int CallsToCenter { get; set; }
    }
}
