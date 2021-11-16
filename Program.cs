using ChoETL;
using System;

namespace FromJsonToCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            ChoCSVRecordConfiguration сhoCSVRecordConfiguration = new();
            int wordInCMDCount = 0;
            foreach (string arg in args)
            {
                if (wordInCMDCount == args.Length - 1)
                    break;
                else if (arg.IndexOf(ParametersWork.FirstCharOfAnyParameter) == 0
                    && arg.IndexOf(KeyParameter.SecondCharOfKeyParameter) == 1
                    && args[wordInCMDCount + 1] == KeyParameter.Key)
                    Environment.Exit(0);

                if (arg.IndexOf(ParametersWork.FirstCharOfAnyParameter) == 0 && arg.IndexOf(InputParameter.SecondCharOfInputIndex) == 1)
                {
                    PathKeeper.InputPath = args[wordInCMDCount + 1];
                    JsonFileWork.CreateJsonFile(DataForJsonFile.AddData(), PathKeeper.InputPath);
                }
                if (arg.IndexOf(ParametersWork.FirstCharOfAnyParameter) == 0 && arg.IndexOf(OutputParameter.SecondCharOfOutputIndex) == 1)
                {
                    PathKeeper.OutputPath = args[wordInCMDCount + 1];
                }
                if (arg.IndexOf(ParametersWork.FirstCharOfAnyParameter) == 0 && arg.IndexOf(DelimitParameter.SecondCharForDelimeter) == 1)
                {                    
                    сhoCSVRecordConfiguration.Delimiter = args[wordInCMDCount + 1];
                }
                if (arg.IndexOf(ParametersWork.FirstCharOfAnyParameter) == 0 && arg.IndexOf(EncodingParameter.ArgumentValue) == 1)
                {
                    EncodingParameter.InputEncoding = args[wordInCMDCount + 1];
                    сhoCSVRecordConfiguration.Encoding = EncodingParameter.SetCurrentEncoding(EncodingParameter.InputEncoding);
                }
                wordInCMDCount++;
            }
            if (PathKeeper.OutputPath == null)
            {
                PathKeeper.OutputPath = PathKeeper.InputPath.Replace(".json",".csv");
            }
            using var JsonReader = new ChoJSONReader(PathKeeper.InputPath);
            try
            {
                using var toCSVWriter = new ChoCSVWriter(PathKeeper.OutputPath, сhoCSVRecordConfiguration).WithFirstLineHeader();
                toCSVWriter.Write(JsonReader);
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка создания csv файла, проверьте введённые параметры.");
            }

        }

    }
}
