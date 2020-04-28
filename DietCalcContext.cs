using DietCalc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DietCalc
{
    public class DietCalcContext : DbContext
    {
        public DietCalcContext() : base("DietCalcContext") { }

        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) => base.OnModelCreating(modelBuilder);
    }
}