using System;
using System.Collections.Generic;
using System.Text;

namespace Cellular.Common.DTOs
{
    public class ClientType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public double MinutePrice { get; set; }
        public double SmsPrice { get; set; }
    }
}
