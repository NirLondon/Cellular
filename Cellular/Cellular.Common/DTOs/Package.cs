using System;
using System.Collections.Generic;
using System.Text;

namespace Cellular.Common.DTOs
{
    public class Package
    {
        public int Id { get; set; }
        public string PackageName { get; set; }
        public double PackageTotalPrice { get; set; }
        public double DiscountPrecentage { get; set; }
        public List<int> FavoriteNumbersId { get; set; }
        public int MostCalledNumber { get; set; }
        public int MaxMinutes { get; set; }
        public int MaxSms { get; set; }

    }
}
