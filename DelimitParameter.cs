using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromJsonToCSV
{

    static class DelimitParameter
    {
        static private string _secondCharForDelimeter = "s";
        static public string SecondCharForDelimeter { get { return secondCharForDelimeter; } }
        static public string Delimeter { get; set; }
    }
}
