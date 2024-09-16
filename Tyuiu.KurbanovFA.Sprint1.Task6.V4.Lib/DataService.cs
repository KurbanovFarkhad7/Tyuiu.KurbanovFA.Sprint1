using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KurbanovFA.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {
            string s, s1;
            s1 = "";
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] != ' ')
                {
                    s1 += value[i];
                }
                else
                {
                    if (s1.Contains("нн"))
                    {
                        s1 = "";
                    }
                }
            }
            return value;
        }
    }
}
