namespace Tyuiu.YakovlevVAa.Sprint5.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V2.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}