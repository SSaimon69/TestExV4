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
            Console.Write("Чтение файла заняло ");
            WriteColorYellow(read.ElapsedMilliseconds.ToString());
            Console.WriteLine(" мс");


            //Создаем экземпляр клиента и информируем о его состоянии
            CalcServiceReference.ServiceClient client = new CalcServiceReference.ServiceClient();
            Console.Write("Служба по адресу ");
            WriteColorYellow(client.Endpoint.Address.ToString());
            Console.Write(" находится в состоянии ");
            WriteColorYellow(client.State.ToString());
            Console.WriteLine();

            //Передача файла и получение результата
            Stopwatch calc = Stopwatch.StartNew();
            var map = client.CalculateWordMultiService(text);
            calc.Stop();
            Console.Write("Передача файла и его обработка заняла ");
            WriteColorYellow(calc.ElapsedMilliseconds.ToString());
            Console.WriteLine(" мс");

            //Сортировка
            var sort = map.OrderByDescending(x => x.Value);

            //Вывод в файл
            using (StreamWriter sw = File.CreateText("textOut.txt"))
            {
                foreach (var x in sort)
                {
                    sw.WriteLine(x.Key + " " + x.Value);
                }
                Console.WriteLine("Результаты вычислений сохранены в файл textOut.txt");
            }
            Console.WriteLine("Нажмите любую кнопку для выхода");
            Console.ReadKey();
        }

        static void WriteColorYellow(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(text);
            Console.ResetColor();
        }
    }
}
