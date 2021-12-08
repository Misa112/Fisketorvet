using Fisketorvet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fisketorvet.Interfaces
{
    public interface IProductRepository
    {
        List<Product> AllProducts();

        void CreateProduct(Product product);

        List<Product> FilterProduct(string criteria);

        Product GetProduct(int id);

        void DeleteProduct(int id);
        List<Product> SearchProductByStore(string storeName);
    }
}
