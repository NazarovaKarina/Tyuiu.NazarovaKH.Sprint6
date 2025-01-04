using Tyuiu.NazarovaKH.Sprint6.Task0.V3.Lib;

namespace Tyuiu.NazarovaKH.Sprint6.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 4.154;
            Assert.AreEqual(wait, res);
        }
    }
}