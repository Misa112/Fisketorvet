using Fisketorvet.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Fisketorvet.Helpers
{
    public class JsonFileWritter
    {

        public static void WriteToJson(List<Customer> customers, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(customers,
                                                               Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }

        public static void WriteToJsonStore(List<Store> stores, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(stores, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }

        public static void WriteToJsonProduct(List<Product> products, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(products, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }
    }
}