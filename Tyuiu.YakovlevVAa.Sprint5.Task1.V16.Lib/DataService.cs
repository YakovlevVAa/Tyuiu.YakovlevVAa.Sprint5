using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.YakovlevVAa.Sprint5.Task1.V16.Lib
{
    public class DataService : ISprint5Task1V16
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            double y;
            string strY;
            for (double x = startValue; x <= stopValue; x++)
            {
                y = Math.Sin(x) + (2 * x) / 3 - Math.Cos(x) * 4 * x;
                y = Math.Round(y, 2);
                strY = Convert.ToString(y);
                if (double.IsInfinity(y) ||  double.IsNaN(y))
                {
                    y = 0;
                }
                if ( x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
                
            }
            return path;
        }
    }
}
