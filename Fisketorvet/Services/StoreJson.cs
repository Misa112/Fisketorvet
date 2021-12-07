using Fisketorvet.Helpers;
using Fisketorvet.Interfaces;
using Fisketorvet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fisketorvet.Services
{
    public class StoreJson : IStoreRepository
    {
        string JsonFileName = @"C:\Users\micha\source\repos\Fisketorvet\Fisketorvet\Data\JsonStores.json";

        public List<Store> AllStores()
        {
            return JsonFileReader.ReadJson(JsonFileName);
        }
        public void CreateStore(Store store)
        {
            List<Store> stores = AllStores();
            stores.Add(store);
            JsonFileWritter.WriteToJson(stores, JsonFileName);
        }

        public List<Store> FilterStore(string criteria)
        {
            List<Store> stores = AllStores();
            List<Store> filteredStores = new List<Store>();

            foreach (var store in stores)
            {
                if(store.StoreName.StartsWith(criteria))
                {
                    filteredStores.Add(store);
                }
            }
            return filteredStores;
        }
        

        public void DeleteStore(Store store)
        {
            throw new NotImplementedException();
        }

        

        public Store GetStore(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateStore(Store store)
        {
            throw new NotImplementedException();
        }
    }
}
