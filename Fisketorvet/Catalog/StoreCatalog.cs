using Fisketorvet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fisketorvet.Catalogs
{
    public class StoreCatalog
    {
        private Dictionary<int, Store> stores { get; }
        private static StoreCatalog _instance;

        private StoreCatalog()
        {
            stores = new Dictionary<int, Store>();
            stores.Add(1, new Store() { StoreId = 1, StoreName = "AND KEBAB", TheStoreType = Store.StoreType.Restaurant, TheShopType = Store.ShopType.Restaurant, TelContact = 12345678, Offer = null, ImageName = "andKebab.png" });
            stores.Add(2, new Store() { StoreId = 2, StoreName = "BEAUTY HAIR", TheStoreType = Store.StoreType.Shop, TheShopType = Store.ShopType.Services, TelContact = 60987541, Offer = "10 %", ImageName = "beautyhair.jpg" });
            stores.Add(3, new Store() { StoreId = 3, StoreName = "BOOK & IDEA", TheStoreType = Store.StoreType.Shop, TheShopType = Store.ShopType.BookAndElectronics, TelContact = 81456935, Offer = "5 for 4", ImageName = "book.png" });
            stores.Add(4, new Store() { StoreId = 4, StoreName = "THE ELECTRICITY GIANT", TheStoreType = Store.StoreType.Shop, TheShopType = Store.ShopType.BookAndElectronics, TelContact = 47458962, Offer = null, ImageName = "elgiganten.png" });
            stores.Add(5, new Store() { StoreId = 5, StoreName = "ESPRESSO HOUSE", TheStoreType = Store.StoreType.Restaurant, TheShopType = Store.ShopType.Restaurant, TelContact = 72658942, Offer = null, ImageName = "EspressoHouse.png" });
            stores.Add(6, new Store() { StoreId = 6, StoreName = "FOTEX", TheStoreType = Store.StoreType.Shop, TheShopType = Store.ShopType.Groceries, TelContact = 90658423, Offer = null, ImageName = "fotex.png" });
            stores.Add(7, new Store() { StoreId = 7, StoreName = "HAPPY BOBBA", TheStoreType = Store.StoreType.Restaurant, TheShopType = Store.ShopType.Restaurant, TelContact = 48596231, Offer = null, ImageName = "HappyBoba.png" });
            stores.Add(8, new Store() { StoreId = 8, StoreName = "H&M", TheStoreType = Store.StoreType.Shop, TheShopType = Store.ShopType.Fashion, TelContact = 45698524, Offer = null, ImageName = "hm.png" });
            stores.Add(9, new Store() { StoreId = 9, StoreName = "HUNKEMÖLLER", TheStoreType = Store.StoreType.Shop, TheShopType = Store.ShopType.Fashion, TelContact = 75869478, Offer = "15 %", ImageName = "hunkemoller.png" });
            stores.Add(10, new Store() { StoreId = 10, StoreName = "JOE AND THE JUICE", TheStoreType = Store.StoreType.Restaurant, TheShopType = Store.ShopType.Restaurant, TelContact = 76859321, Offer = null, ImageName = "JoeAndTheJuice.png" });
            stores.Add(11, new Store() { StoreId = 11, StoreName = "LETZ SUSHI", TheStoreType = Store.StoreType.Restaurant, TheShopType = Store.ShopType.Restaurant, TelContact = 63254896, Offer = null, ImageName = "LetzSushi.png" });
            stores.Add(12, new Store() { StoreId = 12, StoreName = "LIDL", TheStoreType = Store.StoreType.Shop, TheShopType = Store.ShopType.Groceries, TelContact = 60235874, Offer = null, ImageName = "lidl.png" });
            stores.Add(13, new Store() { StoreId = 13, StoreName = "MCDONALDS", TheStoreType = Store.StoreType.Restaurant, TheShopType = Store.ShopType.Restaurant, TelContact = 74125896, Offer = "Free donut", ImageName = "McDonalds.png" });
            stores.Add(14, new Store() { StoreId = 14, StoreName = "ONLY", TheStoreType = Store.StoreType.Shop, TheShopType = Store.ShopType.Fashion, TelContact = 66665897, Offer = null, ImageName = "Only.png" });
            stores.Add(15, new Store() { StoreId = 15, StoreName = "PURE BICYCLE", TheStoreType = Store.StoreType.Shop, TheShopType = Store.ShopType.Services, TelContact = 40446985, Offer = null, ImageName = "purebicycle.png" });
            stores.Add(16, new Store() { StoreId = 16, StoreName = "RITUAL", TheStoreType = Store.StoreType.Shop, TheShopType = Store.ShopType.HealthAndBeauty, TelContact = 98466025, Offer = "15 % on sets", ImageName = "ritual.png" });
            stores.Add(17, new Store() { StoreId = 17, StoreName = "STARBUCKS", TheStoreType = Store.StoreType.Restaurant, TheShopType = Store.ShopType.Restaurant, TelContact = 70796544, Offer = null, ImageName = "Starbucks.png" });
            stores.Add(18, new Store() { StoreId = 18, StoreName = "TELIA", TheStoreType = Store.StoreType.Shop, TheShopType = Store.ShopType.Services, TelContact = 75506552, Offer = null, ImageName = "telia.png" });
            stores.Add(19, new Store() { StoreId = 19, StoreName = "THE BODY SHOP", TheStoreType = Store.StoreType.Shop, TheShopType = Store.ShopType.HealthAndBeauty, TelContact = 62203558, Offer = "3 for 2", ImageName = "thebodyshop.png" });
            stores.Add(20, new Store() { StoreId = 20, StoreName = "ZARA", TheStoreType = Store.StoreType.Shop, TheShopType = Store.ShopType.Fashion, TelContact = 70405010, Offer = null, ImageName = "Zara.jpg" });
        }

        public static StoreCatalog Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StoreCatalog();
                }
                return _instance;
            }
        }
        public Dictionary<int, Store> AllStores()
        {
            return stores;
        }
        public Dictionary<int, Store> FilterStore(string criteria)
        {
            Dictionary<int, Store> filteredStores = new Dictionary<int, Store>();
            if (criteria != null)
            {
                foreach (var item in stores.Values)
                {
                    if (item.StoreName.StartsWith(criteria))
                    {
                        filteredStores.Add(item.StoreId, item);
                    }
                }
            }
            return filteredStores;
        }
        public void CreateStore(Store store)
        {
            if (!stores.ContainsKey(store.StoreId))
            {
                stores.Add(store.StoreId, store);
            }
        }
        public Store GetStore(int id)
        {
            return stores[id];
        }
        public void UpdateStore(Store store)
        {
            if (store != null)
            {
                stores[store.StoreId] = store;
            }
        }
        public void DeleteStore(Store store)
        {
            if (store != null)
            {
                stores.Remove(store.StoreId);
            }
        }
    }
}
