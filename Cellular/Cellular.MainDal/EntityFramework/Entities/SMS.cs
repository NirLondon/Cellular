using System;
using System.ComponentModel.DataAnnotations;

namespace Cellular.MainDal.EntityFramework.Entities
{
    class SMS
    {
        public int ID { get; set; }

        public int LineID { get; set; }
        public Line Line { get; set; }

        [Phone]
        [Required]
        public string DestinationNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
