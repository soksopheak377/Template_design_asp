using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class Offices
    {
        public int OffID { get; set; }
        public string OffName { get; set; }
        public int OffSize { get; set; }
        public char OffImportance { get; set; }
    }
}