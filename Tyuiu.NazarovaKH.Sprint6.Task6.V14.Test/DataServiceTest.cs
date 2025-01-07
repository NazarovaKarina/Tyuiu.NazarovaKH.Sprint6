using Tyuiu.NazarovaKH.Sprint6.Task6.V14.Lib;

namespace Tyuiu.NazarovaKH.Sprint6.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckMethodValid()
        {
            string str = "";
            DataService dataService = new DataService();
            string path = "C:\\DataSprint6\\InPutDataFileTask6V12.txt";
            var res = dataService.CollectTextFromFile(str, path);
            Assert.AreEqual("EzAqSCaJNt loztCm", res);
        }
    }
}