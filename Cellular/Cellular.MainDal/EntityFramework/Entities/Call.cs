using System;
using System.ComponentModel.DataAnnotations;

namespace Cellular.MainDal.EntityFramework.Entities
{
    public class Call
    {
        public int ID { get; set; }

        public int LineID { get; set; }
        public Line Line { get; set; }

        [DataType(DataType.Duration)]
        public TimeSpan Duration { get; set; }

        [Phone]
        [Required]
        public string DestinationNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
