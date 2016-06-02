using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class Product
    {
        public int ProID { get; set; }
        public string ProName { get; set; }
        public string ProClass { get; set; }

        public Employee Offices { get; set; }
    }
}