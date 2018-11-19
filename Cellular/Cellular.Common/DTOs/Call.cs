using System;
using System.Collections.Generic;
using System.Text;

namespace Cellular.Common.DTOs
{
    public class Call
    {
        public string DestinationNumber { get; set; }
        public string CallerNumber { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
