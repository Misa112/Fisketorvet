using Fisketorvet.Models;
using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using System.Collections.Generic;
using System.IO;
using System.Text.Json;


namespace Fisketorvet.Helpers
{
    public class JsonFileReader

    {
        public static List<Customer> ReadJson(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);
            return JsonConvert.DeserializeObject<List<Customer>>(jsonString);

    {        
        public static List<Store> ReadJson(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);
            return JsonConvert.DeserializeObject<List<Store>>(jsonString);

        }
    }
}
