using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BankApp.Models
{
    public class BankDBContext : DbContext
    {
        public BankDBContext()
            :base("name = BankDBContext")
        {

        }
       public DbSet<Customer> Customers { get; set; }
    }
}