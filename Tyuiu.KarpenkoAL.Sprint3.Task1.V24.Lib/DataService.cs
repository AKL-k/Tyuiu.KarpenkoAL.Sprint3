using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KarpenkoAL.Sprint3.Task1.V24.Lib
{
    public class DataService : ISprint3Task1V24
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i = startValue;
            while (i <= stopValue)
            {
                sumSeries = sumSeries + (Math.Pow((2.0 / (6.0 + Math.Pow(value, i))), i));
                i++;
            }

            return Math.Round(sumSeries, 3);
        }
    }
}
