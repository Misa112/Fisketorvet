using Fisketorvet.Helpers;
using Fisketorvet.Interfaces;
using Fisketorvet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fisketorvet.Services
{
    public class OrderJson : IOrderRepository
    {
        string JsonFileName = @"C:\Users\micha\OneDrive\Desktop\Fisketorvet\Fisketorvet\Data\JsonBookOrders.json";

        public List<Order> GetAllOrders()
        {
            return JsonFileReader.ReadJsonOrder(JsonFileName);
        }
        public void AddOrder(Order order)
        {
            List<Order> orders = GetAllOrders().ToList();
            order.OrderID = GetOrderNumber() + 1;
            orders.Add(order);
            JsonFileWritter.WriteToJsonOrder(orders, JsonFileName);
        }

        private int GetOrderNumber()
        {
            List<int> ids = new List<int>();
            List<Order> orders = GetAllOrders().ToList();
            foreach (var o in orders)
            {
                ids.Add(o.OrderID);
            }
            return ids.Max();
        }
    }
}
