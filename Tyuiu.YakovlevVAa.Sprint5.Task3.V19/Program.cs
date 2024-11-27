using Tyuiu.YakovlevVAa.Sprint5.Task3.V19.Lib;
namespace Tyuiu.YakovlevVAa.Sprint5.Task3.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\victor\AppData\Local\Temp\OutPutFileTask3.bin";
            int x = 3;
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File                                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Яковлев Виктор Александрович | ИИПб-24-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить в  *");
            Console.WriteLine("* бинарный файл OutPutFileTask3.bin и вывести на консоль. Округлить до    *");
            Console.WriteLine("* трёх знаков после запятой.                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("x = " + x);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double y = Math.Round((Math.Pow((double)x, 2) * 2 - 1) / (Math.Sqrt(Math.Pow(x, 2) - 2)), 3);
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                int abc = reader.ReadInt32();
                Console.WriteLine($"{abc}");
            }

        }
    }
}
