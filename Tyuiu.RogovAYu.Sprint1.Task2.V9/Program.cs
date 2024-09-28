using System;
using Tyuiu.RogovAYu.Sprint1.Task2.V9.Lib;

namespace Tyuiu.RogovAYu.Sprint.Task.V
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            double result;

            Console.Title = "Task:1.0.v12| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Задание:   Вычислить объем сферы, зная радиус (3 знака после запятой)   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("* Радиус Сферы:");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.CalculateVolumeCircle(input);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* Объем Сферы = {result}                                                   *");
            Console.WriteLine("***************************************************************************");


            Console.ReadKey();
        }
    }
}

