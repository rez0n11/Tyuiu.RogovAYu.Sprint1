using System;
using Tyuiu.RogovAYu.Sprint1.Task7.V27.Lib;

namespace Tyuiu.RogovAYu.Sprint1.Task7.V27
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            double result;

            Console.Title = "Task:1.7.v27| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие: Вычислить значение функции                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* cos(x**2) + sin(y**2)                 xy - 12                           *");
            Console.WriteLine("* ————————————————————      —       ——————————————                        *");
            Console.WriteLine("*      sin(y) + 1                      15 + cox(x)                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("* x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("* y = ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.Calculate(x,y);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"*  = {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
