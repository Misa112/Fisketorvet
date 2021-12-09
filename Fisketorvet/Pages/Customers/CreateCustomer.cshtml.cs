using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fisketorvet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Fisketorvet.Interfaces;
using Fisketorvet.ViewModels;

namespace Fisketorvet.Pages.Customers
{
    public class CreateCustomerModel : PageModel
    {
        private ICustomerRepository catalog;


        [BindProperty]
        public CustomerViewModel CustomerViewModel { get; set; }

        public CreateCustomerModel(ICustomerRepository catalogService)
        {

            catalog = catalogService;

        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (CustomerViewModel.Password == CustomerViewModel.ConfirmPassword)
            {
                Customer customer = new Customer();
                customer.Name = CustomerViewModel.Name;
                customer.Address = CustomerViewModel.Address;
                customer.PhoneNumber = CustomerViewModel.PhoneNumber;
                customer.Email = CustomerViewModel.Email;
                customer.Password = CustomerViewModel.Password;
                customer.IsAdmin = CustomerViewModel.IsAdmin;
                catalog.CreateCustomer(customer);
                return RedirectToPage("../Users/Login");
            }
            else {
                return RedirectToPage("CreateCustomer");
            }
        }
    }
}
