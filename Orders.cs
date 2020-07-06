﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crystal_Report
{
    public class Orders
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
