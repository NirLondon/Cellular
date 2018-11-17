using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cellular.MainDal.EntityFramework.Entities
{
    class RegisrationDetails
    {
        [ForeignKey(nameof(Registrator))]
        public int EmployeeID { get; set; }
        public Employee Registrator { get; set; }

        public int ClientID { get; set; }
        public Client Client { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
