using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KarpenkoAL.Sprint3.Task2.V14.Lib
{
    public class DataService : ISprint3Task2V14
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multSeries = 1;
            int k = startValue;
            do 
            {
                multSeries = multSeries * Math.Pow(((value * 1.0) / k), 3);
                k++;
            }
            while (k <= stopValue);
            return Math.Round(multSeries, 3);
        }
    }
}
