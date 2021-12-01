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
    public class AllStoresModel : PageModel
    {
        private StoreCatalog catalog;
        public Dictionary<int,Store> Stores { get; set; }
        public AllStoresModel()
        {
            catalog = StoreCatalog.Instance;
        }
        public IActionResult OnGet()
        {
            Stores = catalog.AllStores();
            return Page();
        }
    }
}
