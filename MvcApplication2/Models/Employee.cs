using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class Employee
    {
        public int empID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public byte Age { get; set; }
        public decimal salery { get; set; }


        public ICollection<Offices>Offices{get;set; }
    }
}