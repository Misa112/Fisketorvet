using Fisketorvet.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Fisketorvet.Helpers
{
    public class JsonFileReader
    {        
        public static List<Store> ReadJson(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);
            return JsonConvert.DeserializeObject<List<Store>>(jsonString);
        }
    }
}
