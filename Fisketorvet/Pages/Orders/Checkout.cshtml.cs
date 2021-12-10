using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fisketorvet.Interfaces;
using Fisketorvet.Models;
using Fisketorvet.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fisketorvet.Pages.Orders
{
    public class CheckoutModel : PageModel
    {
        private IOrderRepository catalog;
        private ShoppingCartService cart;
        [BindProperty]
        public Customer Customer { get; set; }
        public Order Order { get; set; }

        public CheckoutModel(IOrderRepository repo, ShoppingCartService service)
        {
            catalog = repo;
            cart = service;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            

            return RedirectToPage("Order", Customer);
        }
    }
}
