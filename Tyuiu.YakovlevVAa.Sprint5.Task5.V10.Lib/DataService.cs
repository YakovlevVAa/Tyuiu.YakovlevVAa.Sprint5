using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.YakovlevVAa.Sprint5.Task5.V10.Lib
{
    public class DataService : ISprint5Task5V10
    {
        public double LoadFromDataFile(string path)
        {
            double sum = 0;
            string data = File.ReadAllText(path);
            string[] strings = data.Split(' ');
            var numbers = new List<double>();
            foreach (string s in strings)
            {
                double number = double.Parse(s, CultureInfo.InvariantCulture);
                numbers.Add(number);
            }
            foreach (double number in numbers)
            {
                if (number % 2  == 0)
                {
                    sum += number;
                }
                
            }
            return sum;

        }
    }
}
