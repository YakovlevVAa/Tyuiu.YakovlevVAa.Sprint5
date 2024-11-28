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
            string strY = File.ReadAllText(path);
            double y = Math.Round(Math.Cos(Convert.ToDouble(strY)) * (Math.Pow(Convert.ToDouble(strY), 3) + Math.Sin(Convert.ToDouble(strY))), 3);
            return y;
        }
    }
}
