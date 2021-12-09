using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fisketorvet.Interfaces;
using Fisketorvet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fisketorvet.Pages.Stores
{
    public class ProductsOfStoreModel : PageModel
    {
        IProductRepository catalog;
        public List<Product> Products { get; private set; }
        public ProductsOfStoreModel(IProductRepository repository)
        {
            catalog = repository;
        }
        public IActionResult OnGet(string storeName)
        {
            Products = new List<Product>();
            if (storeName == null)
            {
                return NotFound();
            }
            Products = catalog.SearchProductByStore(storeName);
            if (Products == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
