using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellular.MainDal.EntityFramework.Entities
{
    [Table("MinutesBanks")]
    public class MinutesBank : PackageInclud
    {
        public short MaxMinutes { get; set; }
    }
}
