using Tyuiu.KurbanovFA.Sprint1.Task3.V19.Lib;

namespace Tyuiu.KurbanovFA.Sprint1.Task3.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Курбанов Ф.А. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Курбанов Фархаджон Азамжанович | РППб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x1, x2, y1, y2;

            Console.WriteLine("Введите x1:");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y1:");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите x2:");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y2:");
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ ВОЗМОЖНОСТИ ХОДА:                                             *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.ElephCanMove(x1,x2,y1,y2));

            Console.ReadLine();
        }
    }
}
