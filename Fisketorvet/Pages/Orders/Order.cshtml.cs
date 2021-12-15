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
    public class OrderModel : PageModel
    {
        private ICustomerRepository catalog;
        private ShoppingCartService cart;
        
        
        public string Name  { get; set; }

        public string Address { get; set; }
        public Order Order { get; set; }
        public List<Product> cartItems { get; set; }
        public OrderModel(ICustomerRepository catalogService, ShoppingCartService service)
        {
            catalog = catalogService;
            cart = service;
        }
        public IActionResult OnGet(string name, string address)
        {
            cartItems = cart.GetOrderedProducts();
            Name = name;
            Address = address;

            if (cartItems?.Count() <= 0)
            {
                return Redirect("ShoppingCart");
            }
            return Page();
        }
    }
}
