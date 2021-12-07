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
    public class DeleteStoreModel : PageModel
    {
        [BindProperty]
        public Store Store { get; set; }
        private IStoreRepository catalog;
        public DeleteStoreModel(IStoreRepository repository)
        {
            catalog = repository;
        }
        public void OnGet(int id)
        {
            Store = catalog.GetStore(id);
        }
        public IActionResult OnPost(int id)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            catalog.DeleteStore(id);
            return RedirectToPage("AllStores");
        }
    }
}
