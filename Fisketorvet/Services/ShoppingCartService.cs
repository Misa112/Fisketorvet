using Fisketorvet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fisketorvet.Services
{
    public class ShoppingCartService
    {
        List<Product> itemsInCart;

        public ShoppingCartService()
        {
            itemsInCart = new List<Product>();
        }

        public void AddProductToCart(Product product)
        {
            itemsInCart.Add(product);
        }

        public void RemoveProductFromCart(int id)
        {
            foreach (var p in itemsInCart)
            {
                if(p.ProductId == id)
                {
                    itemsInCart.Remove(p);
                }
            }
        }

        public double TotalPrice()
        {
            double totalPrice = 0;
            foreach (var p in itemsInCart)
            {
                totalPrice += p.Price;                
            }            
            return totalPrice;
        }

        public List<Product> GetOrderedProducts()
        {
            return itemsInCart;
        }
    }
}
