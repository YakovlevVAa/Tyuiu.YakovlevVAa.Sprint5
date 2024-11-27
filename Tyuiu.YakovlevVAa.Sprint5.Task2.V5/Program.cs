using Tyuiu.YakovlevVAa.Sprint5.Task2.V5.Lib;
namespace Tyuiu.YakovlevVAa.Sprint5.Task2.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File                                                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Яковлев Виктор Александрович | ИИПб-24-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры. Заменить нечетные элементы массива на 0.       *");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] matrix = new int[3,3] { { 9, 6, 6 }, { 8, 7, 2 }, { 1, 7, 8 } };
            int row, column;
            row = matrix.GetUpperBound(0) + 1;
            column = matrix.Length / row;
            Console.WriteLine("Массив:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(matrix);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            string abc = File.ReadAllText(res);
            Console.WriteLine($"{abc}");
        }
    }
}
