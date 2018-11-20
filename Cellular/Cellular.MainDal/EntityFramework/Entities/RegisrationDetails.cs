using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cellular.MainDal.EntityFramework.Entities
{
    public class RegisrationDetails
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey(nameof(Registrator))]
        public int EmployeeID { get; set; }
        public Employee Registrator { get; set; }

        [Key]
        [Column(Order = 1)]
        public int ClientID { get; set; }
        public Client Client { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
