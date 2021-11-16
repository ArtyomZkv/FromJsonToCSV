using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromJsonToCSV
{
    static class OutputParameter
    {
        private static readonly string _secondCharOfOutputIndex = "o";
        static public string SecondCharOfOutputIndex { get { return _secondCharOfOutputIndex; } }
        static public void FindCurrentOutputParameter(string arg)
        {
            if (arg.IndexOf(ParametersWork.FirstCharOfAnyParameter) != 0 && arg.IndexOf(SecondCharOfOutputIndex) != 1)
            {
                PathKeeper.OutputPath = arg;
            }
        }
    }
}
