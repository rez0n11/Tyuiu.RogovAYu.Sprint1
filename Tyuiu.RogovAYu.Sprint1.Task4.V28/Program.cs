using System;
using Tyuiu.RogovAYu.Sprint1.Task4.V28.Lib;

namespace Tyuiu.RogovAYu.Sprint1.Task4.V38
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            double result;

            Console.Title = "Task:1.4.v28| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие: Вычислить cos(60*pi / 2) / Exp(2 * x + y)                      *");
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
            Console.WriteLine($"* cos(60*pi / 2) / Exp(2 * {x} + {y}) = {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
