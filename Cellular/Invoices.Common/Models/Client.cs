﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Invoices.Common.Models
{
    class Client
    {
        public int ID { get; set; }

        public List<Line> Lines { get; set; }
    }
}
