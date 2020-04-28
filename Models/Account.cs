using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DietCalc.Models
{
    public class Account
    {
        public int AccountID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

    }
}