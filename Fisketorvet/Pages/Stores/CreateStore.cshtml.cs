using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fisketorvet.Catalogs;
using Fisketorvet.Interfaces;
using Fisketorvet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fisketorvet.Pages.Stores
{
    public class CreateStoreModel : PageModel
    {
        private IStoreRepository catalog;
        [BindProperty]
        public Store Store { get; set; }
        public CreateStoreModel(IStoreRepository repository)
        {
            catalog = repository;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            catalog.CreateStore(Store);
            return RedirectToPage("AllStores");
        }
    }
}
