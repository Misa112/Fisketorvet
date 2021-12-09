using Fisketorvet.Helpers;
using Fisketorvet.Interfaces;
using Fisketorvet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fisketorvet.Services
{
    public class ProductJson : IProductRepository
    {
        string JsonFileName = @"C:\Users\micha\OneDrive\Desktop\Fisketorvet\Fisketorvet\Data\JsonProduct.json";

        public List<Product> AllProducts()
        {
            return JsonFileReader.ReadJsonProduct(JsonFileName);
        }
        public void CreateProduct(Product product)
        {
            List<Product> products = AllProducts();

            List<int> productIds = new List<int>();
            foreach (var p in products)
            {
                productIds.Add(p.ProductId);
            }
            if (productIds.Count != 0)
            {
                int start = productIds.Max();
                product.ProductId = start + 1;
            }
            else
            {
                product.ProductId = 1;
            }

            products.Add(product);
            JsonFileWritter.WriteToJsonProduct(products, JsonFileName);
        }

        public List<Product> FilterProduct(string criteria)
        {
            List<Product> productes = AllProducts();
            List<Product> filteredProducts = new List<Product>();

            foreach (var p in productes)
            {
                if (p.ProductName.StartsWith(criteria))
                {
                    filteredProducts.Add(p);
                }
            }
            return filteredProducts;
        }

        public Product GetProduct(int id)
        {
            List<Product> products = AllProducts();

            foreach (var p in products)
            {
                if (p.ProductId == id)
                {
                    return p;
                }
            }
            return new Product();
        }

        public void DeleteProduct(int id)
        {
            List<Product> products = AllProducts();

            foreach (var p in products)
            {
                if (p.ProductId == id)
                {
                    products.Remove(p);
                    break;
                }
            }
            JsonFileWritter.WriteToJsonProduct(products, JsonFileName);
        }

        public List<Product> SearchProductByStore(string storename)
        {
            List<Product> searchedList = new List<Product>();

            foreach (var p in AllProducts().ToList())
            {
                if(p.Store == storename)
                {
                    searchedList.Add(p);
                }
            }
            return searchedList;
        }
    }
}

