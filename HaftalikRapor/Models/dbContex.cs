using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HaftalikRapor.Models
{
    public class dbContex : DbContext
    {
        public dbContex():base("name=DbModels")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Reports> Reports { get; set; }
    }
}