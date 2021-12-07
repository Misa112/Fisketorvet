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
        public static void WriteToJson(List<Store> stores, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(stores, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }
    }
}
