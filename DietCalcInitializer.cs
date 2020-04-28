using DietCalc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DietCalc
{
    public class DietCalcInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DietCalcContext>
    {
        protected override void Seed(DietCalcContext context) {
            var accounts = new List<Account>
            {
                new Account {Name="Jan Kolo", Email="jan.kolo@gmail.com", PasswordHash="soMeHasH#" }
            };

            accounts.ForEach(a => context.Accounts.Add(a));
            context.SaveChanges();
        }
    }
}