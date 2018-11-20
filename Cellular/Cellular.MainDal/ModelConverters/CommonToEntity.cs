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
                ID = client.ClientId,
                /////
            };
        }

        public static EntityFramework.Entities.PackageInclud ToEntity(this Common.DTOs.PackageInclud packageInclud)
        {
            return new EntityFramework.Entities.PackageInclud
            {
                 ID = packageInclud.ID,
                 PackageID = packageInclud.PackageID,
                  Price = packageInclud.Price
            };
        }

        public static EntityFramework.Entities.Package ToEntity(this Common.DTOs.Package package)
        {
            return new EntityFramework.Entities.Package
            {
                 ID = package.ID,
                  PackageIncluds = package.PackageIncluds
            };
        }
    }
}
