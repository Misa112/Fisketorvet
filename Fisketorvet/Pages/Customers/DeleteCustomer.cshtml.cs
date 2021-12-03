using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fisketorvet.Catalogs;
using Fisketorvet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fisketorvet.Pages.Customers
{
    public class DeleteCustomerModel : PageModel
    {
        private CustomerCatalog catalog;

        [BindProperty]
        public Customer Customer { get; set; }

        public DeleteCustomerModel()
        {
            catalog = CustomerCatalog.Instance;
        }
        public void OnGet(int id)
        {
            Customer = catalog.GetCustomer(id);
            
        }

        public IActionResult OnPost()
        {
            catalog.DeleteCustomer(Customer);
            return RedirectToPage("AllCustomers");
        }
    }
}
