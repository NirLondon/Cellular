using Cellular.Common.DTOs;
using Cellular.MainDal.EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellular.MainDal.ModelConverters
{
    public static class EntityToCommon
    {
        public static Common.DTOs.Client ToCommon(this EntityFramework.Entities.Client client)
        {
            return new Common.DTOs.Client
            {

            };
        }
    }
}
