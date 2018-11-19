using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cellular.MainDal.EntityFramework.Entities;
using Cellular.Common.DTOs;

namespace Cellular.MainDal.ModelConverters
{
   public static class CommonToEntity
    {
        public static EntityFramework.Entities.Client ToEntity(this Common.DTOs.Client client)
        {
            return new EntityFramework.Entities.Client
            {
                
            };
        }
    }
}
