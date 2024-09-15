using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KurbanovFA.Sprint1.Task2.V6.Lib
{
    public class DataService : ISprint1Task2V6
    {
        public double ConvertMToKm(int value)
        {
            return Math.Round(value * 0.001, 3);
        }
    }
}
