using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cellular.MainDal.EntityFramework.Entities
{
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [ForeignKey(nameof(Type))]
        public ClientTypeEnum ClientTypeID { get; set; }
        public ClientType Type { get; set; }

        [StringLength(maximumLength: 15, MinimumLength = 6)]
        public string Password { get; set; }

        [StringLength(maximumLength: 10, MinimumLength = 9)]
        public string Identity { get; set; }

        [Column("Fisrt Name")]
        [StringLength(maximumLength: 15, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Column("Last Name")]
        [StringLength(maximumLength: 15, MinimumLength = 2)]
        public string LastName { get; set; }

        [EmailAddress]
        [Column("Email Address")]
        public string EmailAddress { get; set; }
        
    }
}
