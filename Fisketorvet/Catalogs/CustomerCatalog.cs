using Fisketorvet.Models;
using Fisketorvet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fisketorvet.Catalogs
{
    public class CustomerCatalog : ICustomerRepository
    {
        private List<Customer> customers { get; }

        //private static CustomerCatalog _instance;
        public CustomerCatalog()
        {
            customers = new List<Customer>();
            customers.Add(new Customer() { CustomerId = 1, Name = "Saugat", Address = "Tagensvej 237", PhoneNumber = "71555810", Email = "saugatkhatiwada10@gmail.com" });
            customers.Add(new Customer() { CustomerId = 2, Name = "Michaela", Address = "Trekoner", PhoneNumber = "776886499", Email = "macejovskamicha@gmail.com" });
            customers.Add(new Customer() { CustomerId = 3, Name = "Sabin", Address = "Husum Trov", PhoneNumber = "31862094", Email = "ghimiresabin147@gmail.com" });
            customers.Add(new Customer() { CustomerId = 4, Name = "Gulce", Address = " Roskdile", PhoneNumber = "543527044", Email = "glcyayla@gmail.com" });
            customers.Add(new Customer() { CustomerId = 5, Name = "Viktor", Address = "Flimtom", PhoneNumber = "71556794", Email = "viktor.bonev02@gmail.com" });
        }


        //public static CustomerCatalog Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //        {
        //            _instance = new CustomerCatalog();
        //        }
        //        return _instance;
        //    }
        //}
        public List<Customer> AllCustomers()
        {
            return customers;
        }

        public void CreateCustomer(Customer customer)
        {
                customers.Add(customer);
        }

        
        public List<Customer> FilterCustomers(string criteria)
        {
            List<Customer> filteredStores = new List<Customer>();
            if (criteria != null)
            {
                foreach (var customer in customers)
                {
                    if (customer.Name.StartsWith(criteria))
                    {
                        filteredStores.Add(customer);
                    }
                }
            }
            return filteredStores;
        }

        public Customer GetCustomer(int id)
        {
            foreach (var customer in customers)
            {
                if (customer.CustomerId == id)
                {
                    return customer;
                }
            }
            return null;
        }

        public void DeleteCustomer(Customer c)
        {
            if (c != null)
            {
                foreach (var cusotmer in customers)
                {
                    if (c.CustomerId == cusotmer.CustomerId)
                    {
                        customers.Remove(cusotmer);
                        break;
                    }
                }
            }
        }
    }
}
