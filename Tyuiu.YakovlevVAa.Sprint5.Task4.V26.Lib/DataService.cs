using System.IO;
using System.Threading.Tasks;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.YakovlevVAa.Sprint5.Task4.V26.Lib
{
    public class DataService : ISprint5Task4V26
    {
        public double LoadFromDataFile(string path)
        {
            path = @"C:\DataSprint5\InPutDataFileTask4V26.txt";
            double x = 0;
            string strY = File.ReadAllText(path);
            x = double.Parse(strY);
            double y = Math.Round(Math.Cos(x) * (Math.Pow(x, 3) + Math.Sin(x)), 3);
            return y;
        }
    }
}
