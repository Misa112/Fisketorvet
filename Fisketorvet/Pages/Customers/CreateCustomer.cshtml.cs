using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Fisketorvet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fisketorvet.Pages.Customers
{
    public class CreateCustomerModel : PageModel
    {
        

        [BindProperty]
        public Customer Customer { get; set; }

        public CreateCustomerModel()
        {
            
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
            //catalog.CreateCustomer(Customer);
            return RedirectToPage("AllCustomers");
        }
    }
}
