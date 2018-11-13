using System;
using System.Collections.Generic;
using System.Text;

namespace Cellular.Common.DTOs
{
    public class Call
    {
        public int Id { get; set; }
        public int LineId { get; set; }
        public double ExternalPrice { get; set; }
        public int DestinationNumber { get; set; }
        public int CallerNumber { get; set; }
        public DateTime CallDate { get; set; }
    }
}
