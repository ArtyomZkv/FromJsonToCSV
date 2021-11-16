using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
namespace FromJsonToCSV
{
    class JsonFileWork
    {
        public static void CreateJsonFile(List<DataForJsonFile> list, string path)
        {
            string json = JsonSerializer.Serialize(list);
            File.WriteAllText(path, json);
        }
    }
}
