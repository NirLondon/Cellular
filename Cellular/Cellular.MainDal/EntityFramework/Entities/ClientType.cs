using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cellular.MainDal.EntityFramework.Entities
{
    [Table("Client Type")]
    class ClientType
    {
        [Key]
        public ClientTypeEnum ID { get; set; }

        [DataType(DataType.Currency)]
        [Column("Call Minute Price")]
        public float CallMinuetePrice{ get; set; }

        [Column("SMS Price")]
        [DataType(DataType.Currency)]
        public float SMSPrice { get; set; }
    }
}