using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.YakovlevVAa.Sprint5.Task6.V6.Lib
{
    public class DataService : ISprint5Task6V6
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            string data = File.ReadAllText(path);
            string res = "";
            foreach (char c in data)
            {
                if (char.IsLower(c) && Regex.IsMatch(Convert.ToString(c), @"\p{IsCyrillic}"))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
