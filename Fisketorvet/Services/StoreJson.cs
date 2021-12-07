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

        public Store GetStore(int id)
        {
            List<Store> stores = AllStores();

            foreach (var s in stores)
            {
                if(s.StoreId == id)
                {
                    return s;
                }
            }
            return new Store();
        }

        //public Country GetCountry(string code)
        //{
        //    foreach (var c in GetAllCountries())
        //    {
        //        if (c.Code == code)
        //            return c;
        //    }
        //    return new Country();
        //}
        //public void DeleteCountry(string code)
        //{
        //    List<Country> countries = GetAllCountries().ToList();

        //    foreach (var c in countries)
        //    {
        //        if (c.Code == code)
        //        {
        //            countries.Remove(c);
        //            break;
        //        }
        //    }
        //    JsonFileCountryWritter.WriteToJson(countries, JsonFileName);
        //}

        public void DeleteStore(int id)
        {
            List<Store> stores = AllStores();

            foreach (var s in stores)
            {
                if(s.StoreId == id)
                {
                    stores.Remove(s);
                    break;
                }
            }            
            JsonFileWritter.WriteToJson(stores, JsonFileName);
        }      
    }
}
