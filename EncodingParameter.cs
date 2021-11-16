using System;
using System.Text;
using ChoETL;

namespace FromJsonToCSV
{
     static class EncodingParameter
    {
        static ChoCSVRecordConfiguration choCSVRecordConfiguration = new();
        static public string InputEncoding { get; set; } 
        static public string ArgumentValue { get; } = "e";
        static public Encoding SetCurrentEncoding(string inputParameter)
        {
            switch (inputParameter)
            {
                case "UTF8":
                    choCSVRecordConfiguration.Encoding = System.Text.Encoding.UTF8;
                    break;
                case "ASСII":
                    choCSVRecordConfiguration.Encoding = System.Text.Encoding.ASCII;
                    break;
                case "Windows-1251":
                    choCSVRecordConfiguration.Encoding = System.Text.Encoding.GetEncoding("windows-1251");
                    break;
                case "Windows-1252":
                    choCSVRecordConfiguration.Encoding = System.Text.Encoding.GetEncoding("windows-1252");
                    break;
                default:
                    Console.WriteLine(value: "Неверно введена кодировка. " +
                        "Выбрана кодировка по умолчанию. " +
                        "Пожалуйста, при необходимости введите одну из кодировок из списка ниже: \n" +
                        "UTF8 \n" +
                        "ASСII \n" +
                        "Windows-1251 \n" +
                        "Windows-1251");
                    break;
            }
            return choCSVRecordConfiguration.Encoding;
        }
    }
}
