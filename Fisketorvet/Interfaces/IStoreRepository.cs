using Fisketorvet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fisketorvet.Interfaces
{
    public interface IStoreRepository
    {
        Dictionary<int, Store> AllStores();
        Dictionary<int, Store> FilterStore(string criteria);
        void CreateStore(Store store);
        Store GetStore(int id);
        void UpdateStore(Store store);
        void DeleteStore(Store store);
    }
}
