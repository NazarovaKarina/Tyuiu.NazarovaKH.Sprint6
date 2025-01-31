﻿using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NazarovaKH.Sprint6.Task4.V16.Lib
{
    public class DataService : ISprint6Task4V16
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 100)
                {
                    valueArray[count] = 0;
                    count++;
                }
                else
                {
                    y = Math.Round(Math.Cos(x) / (x - 0.4) + Math.Sin(x) * 8 * x + 2, 2);
                    valueArray[count] = y;
                    count++;
                }
            }
            return valueArray;
        }
    }
}
