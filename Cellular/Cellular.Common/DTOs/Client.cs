using System;
using System.Collections.Generic;
using System.Text;

namespace Cellular.Common.DTOs
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Identity { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string ClientTypeId { get; set; }
        public string EmailAddress { get; set; }
        public int CallsToCenter { get; set; }
    }
}
