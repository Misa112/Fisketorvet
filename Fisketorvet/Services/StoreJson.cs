﻿using Fisketorvet.Helpers;
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

            List<int> storeIds = new List<int>();
            foreach (var s in stores)
            {
                storeIds.Add(s.StoreId);
            }
            if (storeIds.Count != 0)
            {
                int start = storeIds.Max();
                store.StoreId = start + 1;
            }
            else
            {
                store.StoreId = 1;
            }

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
