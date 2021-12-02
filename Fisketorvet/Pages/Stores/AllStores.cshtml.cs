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
    public class AllStoresModel : PageModel
    {
        private IStoreRepository catalog;
        public Dictionary<int,Store> Stores { get; private set; }
        public AllStoresModel(IStoreRepository repository)
        {
            catalog = repository;
        }
        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }
        public Dictionary<int,Store> FilteredStore { get; set; }
        public IActionResult OnGet()
        {
            Stores = catalog.AllStores();

            if(!string.IsNullOrEmpty(FilterCriteria))
            {
                Stores = catalog.FilterStore(FilterCriteria);
            }
            return Page();
        }
    }
}
