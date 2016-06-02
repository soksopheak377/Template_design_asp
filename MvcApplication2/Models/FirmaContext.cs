using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class FirmaContext :DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Offices> Offaces { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}