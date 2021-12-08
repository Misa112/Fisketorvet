using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fisketorvet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Fisketorvet.Interfaces;

namespace Fisketorvet.Pages.Customers
{
    public class CreateCustomerModel : PageModel
    {
        private ICustomerRepository catalog;


        [BindProperty]
        public Customer Customer { get; set; }

        public CreateCustomerModel(ICustomerRepository catalogService)
        {

            catalog = catalogService;

        }

        public void OnGet()
        {
            //return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            catalog.CreateCustomer(Customer);
            return RedirectToPage("AllCustomers");
        }
    }
}
