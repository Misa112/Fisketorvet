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
    public class AllCustomersModel : PageModel
    {
        public Dictionary<int, Customer> Customers { get; set; }

        private CustomerCatalog catalog;

        public AllCustomersModel()
        {
            catalog = CustomerCatalog.Instance;
        }
        public IActionResult OnGet()
        {
            Customers = catalog.AllCustomers();
            return Page();
        }
    }
}
