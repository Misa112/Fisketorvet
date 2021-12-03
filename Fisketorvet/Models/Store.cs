using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fisketorvet.Models
{
    public class Store
    {        
        public int StoreId { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Name of the store can not be longer than 20 characters.")]
        public string StoreName { get; set; }
        public enum StoreType { Shop, Restaurant }
        public StoreType TheStoreType { get; set; }
        public enum ShopType { Groceries, Fashion, HealthAndBeauty, BookAndElectronics, Services, Restaurant}
        public ShopType TheShopType { get; set; }        
        [Range(10000000, 99999999, ErrorMessage = "Telephone number should be in format: xxxxxxxx")]
        public int TelContact { get; set; }

        //not sure about type
        //public DateTime OpeningTime { get; set; }

        public string Offer { get; set; }
        public string ImageName { get; set; }
    }
}
