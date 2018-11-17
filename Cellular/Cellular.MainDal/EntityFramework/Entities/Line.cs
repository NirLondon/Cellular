using System.ComponentModel.DataAnnotations;

namespace Cellular.MainDal.EntityFramework.Entities
{
    class Line
    {
        public int ID { get; set; }

        public int ClientID { get; set; }
        public Client Client { get; set; }

        [Phone]
        [Required]
        public string Number { get; set; }
    }
}