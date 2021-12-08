﻿using Fisketorvet.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Fisketorvet.Helpers
{
    public class JsonFileReader
    {
        public static List<Customer> ReadJson(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);
            return JsonConvert.DeserializeObject<List<Customer>>(jsonString);
        }
    }
}
