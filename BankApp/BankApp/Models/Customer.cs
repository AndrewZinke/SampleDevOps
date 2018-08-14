using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankApp.Models
{
    public class Customer
    {

        public int CustomerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string loanAmount { get; set; }


        //private static List<Customer> _customers = new List<Customer>()
        //{
        //    new Customer {Id = 101, FirstName ="Bilbo", LastName = "Baggins", Email = "thereandback@mordor.com", DOB = new DateTime(12/12/12) },
        //    new Customer {Id = 102, FirstName = "Harry", LastName = "Potter", Email = "thechosenone@hogwarts.com", DOB = new DateTime(11/11/11) },
        //    new Customer {Id = 103, FirstName = "Jim", LastName = "Jimbo", Email = "jimmyjoe@james.com", DOB = new DateTime(3/3/3)}
        //};

        //public List<Customer> Get()
        //{
        //    return _customers;
        //}

        //public Customer Get(int id)
        //{
        //    var customer = _customers
        //        .Where(c => c.Id == id)
        //        .SingleOrDefault<Customer>();
         

        //    return customer;
        //}
    }
}