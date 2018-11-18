using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AutoCompleteTextBoxDemo.Models
{
    public class CountryDbContext:DbContext
    {
        public DbSet<Country> Country { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<CountryDbContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}