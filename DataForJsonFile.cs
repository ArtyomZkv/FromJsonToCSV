using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromJsonToCSV
{
     class DataForJsonFile
    {
        public int ID { get; set; }
        public int SSN { get; set; }
        public string Name { get; set; }
        public static List<DataForJsonFile> AddData()
        {
            List<DataForJsonFile> jsonList = new();
            jsonList.Add(new DataForJsonFile() { ID = 1, SSN = 1414, Name = "Artyom" });
            jsonList.Add(new DataForJsonFile() { ID = 2, SSN = 4134, Name = "Sergey" });
            jsonList.Add(new DataForJsonFile() { ID = 3, SSN = 1331, Name = "Victor" });
            jsonList.Add(new DataForJsonFile() { ID = 4, SSN = 5345, Name = "Svetlana" });

            return jsonList;
        }
    }
}
