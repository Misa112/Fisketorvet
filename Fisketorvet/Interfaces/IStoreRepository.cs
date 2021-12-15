using Fisketorvet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fisketorvet.Interfaces
{
    public interface IStoreRepository
    {
        List<Store> AllStores();

        void CreateStore(Store store);

        List<Store> FilterStore(string criteria);
        
        Store GetStore(int id);

        void DeleteStore(int id);
    }
}
