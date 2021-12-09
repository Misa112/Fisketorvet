using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fisketorvet.Models;
using Fisketorvet.Interfaces;
using Fisketorvet.ViewModels;

namespace Fisketorvet.Interfaces
{
    public interface ICustomerRepository
    {
        List<Customer> AllCustomers();

        void CreateCustomer(Customer customer);

        List<Customer> FilterCustomers(string criteria);

        Customer GetCustomer(int id);

        void DeleteCustomer(Customer c);
    }
}

