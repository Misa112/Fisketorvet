using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fisketorvet.Interfaces;
using Fisketorvet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fisketorvet.Pages.Products
{
    public class AllProductsAdminModel : PageModel
    {
        private IProductRepository catalog;
        public List<Product> Products { get; private set; }
        public AllProductsAdminModel(IProductRepository repository)
        {
            catalog = repository;
        }
        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }
        public List<Store> FilteredStore { get; set; }
        public IActionResult OnGet()
        {
            Products = catalog.AllProducts();

            if (!string.IsNullOrEmpty(FilterCriteria))
            {
                Products = catalog.FilterProduct(FilterCriteria);
            }
            return Page();
        }
    }
}
