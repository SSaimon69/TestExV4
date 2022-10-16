using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAppClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch read = Stopwatch.StartNew(); 
            //Чтение файла
            string filePath = "text.txt";
            string text = "";
            using (StreamReader stream = new StreamReader(filePath))
            {
                text = stream.ReadToEnd();
            }
            read.Stop();
            Console.WriteLine($"Чтение файла заняло {read.ElapsedMilliseconds} мс");

            //Передача файла и получение результата
            CalcServiceReference.ServiceClient client = new CalcServiceReference.ServiceClient();
            var map = client.CalculateWordMultiService(text);

            //Сортировка
            var sort = map.OrderByDescending(x => x.Value);

            //Вывод в файл
            using (StreamWriter sw = File.CreateText("textOut.txt"))
            {
                foreach (var x in sort)
                {
                    sw.WriteLine(x.Key + " " + x.Value);
                }
            }

            Console.ReadKey();
        }
    }
}
