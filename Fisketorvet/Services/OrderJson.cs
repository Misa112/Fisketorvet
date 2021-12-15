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
        string JsonFileName = @"C:\Users\sauga\source\repos\Fisketorvet\Fisketorvet\Data\JsonOrder.json";

        public List<Order> GetAllOrders()
        {
            return JsonFileReader.ReadJsonOrder(JsonFileName);
        }
        public void AddOrder(Order order)
        {
            List<Order> orders = GetAllOrders();
            List<int> orderIds = new List<int>();
            if (orders != null)
            {
                foreach (var o in orders)
                {
                    orderIds.Add(o.OrderID);
                }
                if (orderIds.Count != 0)
                {
                    int start = orderIds.Max();
                    order.OrderID = start + 1;
                }
            }
            else
            {
                orders = new List<Order>();
                order.OrderID = 1;
            }
            //order.OrderID = GetOrderNumber() + 1;
            orders.Add(order);
            JsonFileWritter.WriteToJsonOrder(orders, JsonFileName);
        }

        //private int GetOrderNumber()
        //{
        //    List<int> ids = new List<int>();
        //    List<Order> orders = GetAllOrders().ToList();
        //    foreach (var o in orders)
        //    {
        //        ids.Add(o.OrderID);
        //    }
        //    return ids.Max();
        //}
    }
}
