using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellular.MainDal.EntityFramework.Entities
{
    [Table("FriendsDiacounts")]
    public class FriendsDiscount : PackageInclud
    {
        [Phone]
        public string Number1 { get; set; }
        [Phone]
        public string Number2 { get; set; }
        [Phone]
        public string Number3 { get; set; }
    }
}
