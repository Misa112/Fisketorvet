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
    public class DeleteProductModel : PageModel
    {
        [BindProperty]
        public Product Product { get; set; }

        private IProductRepository catalog;

        public DeleteProductModel(IProductRepository repository)
        {
            catalog = repository;
        }
        public void OnGet(int id)
        {
            Product = catalog.GetProduct(id);
        }
        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            catalog.DeleteProduct(id);
            return RedirectToPage("AllProductsAdmin");
        }
    }
}
