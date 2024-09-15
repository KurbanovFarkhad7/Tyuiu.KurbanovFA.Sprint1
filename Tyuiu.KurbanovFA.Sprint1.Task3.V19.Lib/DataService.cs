using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KurbanovFA.Sprint1.Task3.V19.Lib
{
    public class DataService : ISprint1Task3V19
    {
        public bool ElephCanMove(double x1, double x2, double y1, double y2)
        {
            if (x2 % x1 == 0 && y2 % y1 == 0)
            {
                return true;
            }
            else { return false; }
        }
    }
}
