using Fisketorvet.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    }
}
