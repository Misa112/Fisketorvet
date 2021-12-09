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
    public class AllCustomersModel : PageModel
    {
        public List<Customer> Customers { get; private set; }
        private ICustomerRepository catalog;

        


        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }

        public AllCustomersModel(ICustomerRepository catalogService)
        {
            catalog = catalogService;
        }
        public IActionResult OnGet()
        {
            
            Customers = catalog.AllCustomers();

            if (!string.IsNullOrEmpty(FilterCriteria))
            {
                Customers = catalog.FilterCustomers(FilterCriteria);
            }
            return Page();
        }
    }
}
