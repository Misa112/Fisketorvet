using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fisketorvet.Catalogs;
using Fisketorvet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fisketorvet.Pages.Stores
{
    public class DeleteStoreModel : PageModel
    {
        [BindProperty]
        public Store Store { get; set; }
        private StoreCatalog catalog;
        public DeleteStoreModel()
        {
            catalog = StoreCatalog.Instance;
        }
        public void OnGet(int id)
        {
            Store = catalog.GetStore(id);
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            catalog.DeleteStore(Store);
            return RedirectToPage("AllStores");
        }
    }
}
