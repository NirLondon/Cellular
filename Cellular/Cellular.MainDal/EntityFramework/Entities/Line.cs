using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cellular.MainDal.EntityFramework.Entities
{
    public class Line
    {
        public int ID { get; set; }

        public int ClientID { get; set; }
        public Client Client { get; set; }

        [Phone]
        [Required]        
        public string Number { get; set; }

        public int PackageID { get; set; }
        public Package Package { get; set; }
    }
}