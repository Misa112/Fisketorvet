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
    public class ShoppingCartModel : PageModel
    {
        public ShoppingCartService CartService { get; }
        public List<Product> OrderedProducts { get; set; }
        private IProductRepository catalog;

        public Product Product { get; set; }

        public ShoppingCartModel(IProductRepository repository, ShoppingCartService cartService)
        {
            catalog = repository;
            CartService = cartService;
            OrderedProducts = new List<Product>();
        }
        public IActionResult OnGet(int id)
        {
            Product Product = catalog.GetProduct(id);
            CartService.AddProductToCart(Product);
            OrderedProducts = CartService.GetOrderedProducts();
            return Page();
        }

        public IActionResult OnPostDelete(int id)
        {
            CartService.RemoveProductFromCart(id);
            OrderedProducts = CartService.GetOrderedProducts();
            return Page();
        }
    }
}

