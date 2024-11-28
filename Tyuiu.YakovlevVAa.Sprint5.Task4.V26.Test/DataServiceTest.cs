namespace Tyuiu.YakovlevVAa.Sprint5.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFileExist()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V26.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}