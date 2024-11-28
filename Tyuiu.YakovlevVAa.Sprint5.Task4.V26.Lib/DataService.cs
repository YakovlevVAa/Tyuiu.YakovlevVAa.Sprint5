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
            
            string strX = File.ReadAllText(path);
            double y = Math.Round(Math.Cos(Convert.ToDouble(strX, new System.Globalization.CultureInfo("en-US"))) * (Math.Pow(Convert.ToDouble(strX, new System.Globalization.CultureInfo("en-US")), 3) + Math.Sin(Convert.ToDouble(strX, new System.Globalization.CultureInfo("en-US")))), 3);
            return y;
        }
    }
}
