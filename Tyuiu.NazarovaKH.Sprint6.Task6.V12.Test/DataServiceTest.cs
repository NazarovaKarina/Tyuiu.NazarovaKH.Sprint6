using Tyuiu.NazarovaKH.Sprint6.Task6.V12.Lib;

namespace Tyuiu.NazarovaKH.Sprint6.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Check()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V12.txt");
            Assert.AreEqual("iKDOjtfsPmw", ds.CollectTextFromFile(path));
        }
    }
}