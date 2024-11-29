using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.YakovlevVAa.Sprint5.Task7.V2.Lib
{
    public class DataService : ISprint5Task7V2
    {
        public string LoadDataAndSave(string path)
        {
            
            string text = File.ReadAllText(path);
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }
            string result = Regex.Replace(text, @"\p{IsCyrillic}", "#");
            File.WriteAllText(path, result);
            return result;
        }
    }
}
