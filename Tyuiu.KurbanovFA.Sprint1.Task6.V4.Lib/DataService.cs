using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KurbanovFA.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {
            string spaceValue = "";
            string valueHolder = "";

            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] != ' ')
                {
                    spaceValue += value[i];
                }
                else
                {
                    if (spaceValue.Contains("нн"))
                    {
                        valueHolder += spaceValue + " ";
                    }
                    spaceValue = "";
                }
            }
            value = valueHolder;
            return value;
        }
    }
}
