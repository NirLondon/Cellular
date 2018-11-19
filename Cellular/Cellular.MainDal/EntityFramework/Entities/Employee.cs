using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cellular.MainDal.EntityFramework.Entities
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(maximumLength:15 ,MinimumLength = 6)]
        public string Password { get; set; }

        [Column("Fisrt Name")]
        [StringLength(maximumLength: 15, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Column("Last Name")]
        [StringLength(maximumLength: 15, MinimumLength = 2)]
        public string LastName { get; set; }
    }
}
