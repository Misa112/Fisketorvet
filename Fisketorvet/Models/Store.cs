using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fisketorvet.Models
{
    public class Store
    {
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public enum StoreType { Shop, Restaurant }
        public StoreType TheStoreType { get; set; }
        public enum ShopType { Groceries, Fashion, HealthAndBeauty, BookAndElectronics, Services, Restaurant}
        public ShopType TheShopType { get; set; }
        public int TelContact { get; set; }

        //not sure about type
        //public DateTime OpeningTime { get; set; }

        public string Offer { get; set; }
        public string ImageName { get; set; }
    }
}
