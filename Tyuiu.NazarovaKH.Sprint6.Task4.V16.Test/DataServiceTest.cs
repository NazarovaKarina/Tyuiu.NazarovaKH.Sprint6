using Tyuiu.NazarovaKH.Sprint6.Task4.V16.Lib;

namespace Tyuiu.NazarovaKH.Sprint6.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();


            int startValue = -5;
            int stopValue = 5;

            int len = (stopValue - startValue) + 1;

            double[] wait;
            wait = new double[len];

            wait[0] = -36.41;
            wait[1] = -22.07;
            wait[2] = 5.68;
            wait[3] = 16.72;
            wait[4] = 8.35;
            wait[5] = -0.5;
            wait[6] = 9.63;
            wait[7] = 16.29;
            wait[8] = 5.01;
            wait[9] = -22.4;
            wait[10] = -36.3;

            double[] valueArray;
            valueArray = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(wait, valueArray);
        }
    }
}