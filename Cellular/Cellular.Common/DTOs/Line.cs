using System;
using System.Collections.Generic;
using System.Text;

namespace Cellular.Common.DTOs
{
    public class Line
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int PhoneNumber { get; set; }
        public string Status { get; set; }
        public int PackageId { get; set; }
    }
}
