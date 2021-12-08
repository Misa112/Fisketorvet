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
    public class CreateProductModel : PageModel
    {        
        private IProductRepository catalog;
        [BindProperty]
        public Product Product { get; set; }
        public CreateProductModel(IProductRepository repository)
        {
            catalog = repository;
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
            catalog.CreateProduct(Product);
            return RedirectToPage("AllProducts");
        }    
    }    
}
