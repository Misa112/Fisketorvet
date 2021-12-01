using Fisketorvet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fisketorvet.Catalogs
{
    public class CustomerCatalog
    {
        private Dictionary<int, Customer> customers { get; }
        public CustomerCatalog()
        {
            customers = new Dictionary<int, Customer>();
            customers.Add(1, new Customer() { CustomerId = 1, Name = "Saugat", Address = "Tagensvej 237", PhoneNumber = 71555810, Email = "saugatkhatiwada10@gmail.com" });
            customers.Add(2, new Customer() { CustomerId = 2, Name = "Michaela", Address = "Trekoner", PhoneNumber = 776886499, Email = "macejovskamicha@gmail.com" });
            customers.Add(3, new Customer() { CustomerId = 3, Name = "Sabin", Address = "Husum Trov", PhoneNumber = 31862094, Email = "ghimiresabin147@gmail.com" });
            customers.Add(4, new Customer() { CustomerId = 4, Name = "Gulce", Address = " Roskdile", PhoneNumber = 543527044, Email = "glcyayla@gmail.com" });
            customers.Add(5, new Customer() { CustomerId = 5, Name = "Viktor", Address = "Flimtom", PhoneNumber = 71556794, Email = "viktor.bonev02@gmail.com" });
        }

        public Dictionary<int, Customer> AllCustomers()
        {
            //return new Dictionary<int,Customer>();
            //Dictionary<int, Customer> empty = new Dictionary<int, Customer>();
            //if (customers == null) return empty;
            //else
            //{
            //    foreach (Customer c in customers.Values)
            //    {
            //        empty.Add(c.Id, c);
            //    }
            //    return empty;
            //}
            return customers;

        }
    }
}
