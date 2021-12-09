using Fisketorvet.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;


namespace Fisketorvet.Helpers
{
    public class JsonFileReader

    {
        public static List<Customer> ReadJson(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);
            return JsonConvert.DeserializeObject<List<Customer>>(jsonString);
        }

        public static List<Store> ReadJsonStore(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);
            return JsonConvert.DeserializeObject<List<Store>>(jsonString);
        }

        public static List<Product> ReadJsonProduct(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);
            return JsonConvert.DeserializeObject<List<Product>>(jsonString);
        }

        public static List<Order> ReadJsonOrder(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);
            return JsonConvert.DeserializeObject<List<Order>>(jsonString);
        }

    }
}
