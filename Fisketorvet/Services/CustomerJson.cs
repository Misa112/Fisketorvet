using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Fisketorvet.Helpers;
using Fisketorvet.Interfaces;
using Fisketorvet.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fisketorvet.Services
{
    public class CustomerJson : ICustomerRepository
    {
        //public IWebHostEnvironment WebHostEnvironment { get; }

        //public CustomerJson(IWebHostEnvironment webHostEnvironment)
        //{
        //    WebHostEnvironment = webHostEnvironment;
        //}

        //private string JsonFileName
        //{
        //    get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "JsonCustomer.json"); }
        //}


       string JsonFileName = @"C:\Users\sauga\source\repos\Fisketorvet\Fisketorvet\Data\JsonCustomer.json";

        public List<Customer> AllCustomers() 
        {
            return JsonFileReader.ReadJson(JsonFileName);
        }

        public void CreateCustomer(Customer customer)
        {
            List<Customer> customers = AllCustomers();

            List<int> cutomerIds = new List<int>();
            if (customers != null) {
                foreach (var c in customers)
                {
                    cutomerIds.Add(c.CustomerId);
                }
                if (cutomerIds.Count != 0)
                {
                    int start = cutomerIds.Max();
                    customer.CustomerId = start + 1;
                }
            }   
            else
            {
                customers = new List<Customer>();
                customer.CustomerId = 1;
            }
            customer.Password = PasswordHash(customer.Email, customer.Password);
            customers.Add(customer);
            JsonFileWritter.WriteToJson(customers, JsonFileName);
        }

        public void DeleteCustomer(Customer c)
        {
            List<Customer> customers = AllCustomers();

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
            JsonFileWritter.WriteToJson(customers, JsonFileName);
        }

        public List<Customer> FilterCustomers(string criteria)
        {
            List<Customer> customers = AllCustomers();
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
            List <Customer> customers = AllCustomers();
            foreach (var customer in customers)
            {
                if (customer.CustomerId == id)
                {
                    return customer;
                }
            }
            return new Customer();
        }

        private string PasswordHash(string email, string password)
        {
            PasswordHasher<string> pw = new PasswordHasher<string>();
            string passwordHashed = pw.HashPassword(email, password);
            return passwordHashed;
        }
    }
}
