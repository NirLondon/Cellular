﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cellular.Common.DTOs
{
    public class Package
    {
        public int ID { get; set; }

        public  List<PackageInclud> PackageIncluds { get; set; }

    }
}
