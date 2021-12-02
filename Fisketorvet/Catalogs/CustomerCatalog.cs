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

        private static CustomerCatalog _instance;
        public CustomerCatalog()
        {
            customers = new Dictionary<int, Customer>();
            customers.Add(1, new Customer() { CustomerId = 1, Name = "Saugat", Address = "Tagensvej 237", PhoneNumber = "71555810", Email = "saugatkhatiwada10@gmail.com" });
            customers.Add(2, new Customer() { CustomerId = 2, Name = "Michaela", Address = "Trekoner", PhoneNumber = "776886499", Email = "macejovskamicha@gmail.com" });
            customers.Add(3, new Customer() { CustomerId = 3, Name = "Sabin", Address = "Husum Trov", PhoneNumber = "31862094", Email = "ghimiresabin147@gmail.com" });
            customers.Add(4, new Customer() { CustomerId = 4, Name = "Gulce", Address = " Roskdile", PhoneNumber = "543527044", Email = "glcyayla@gmail.com" });
            customers.Add(5, new Customer() { CustomerId = 5, Name = "Viktor", Address = "Flimtom", PhoneNumber = "71556794", Email = "viktor.bonev02@gmail.com" });
        }


        public static CustomerCatalog Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CustomerCatalog();
                }
                return _instance;
            }
        }
        public Dictionary<int, Customer> AllCustomers()
        {
            return customers;
        }

        public void CreateCustomer(Customer customer)
        {
            if (!customers.ContainsKey(customer.CustomerId))
            {
                customers.Add(customer.CustomerId, customer);
            }
        }
    }
}
