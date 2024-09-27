using System;
using Tyuiu.RogovAYu.Sprint1.Task0.V12.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RogovAYu.Sprint1.Task0.V12
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            Console.Title = "Task:1.0.v12| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* Спринт #1");
            Console.WriteLine("* Задание #0");
            Console.WriteLine("* Вариант #12");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1");
            Console.WriteLine(new string('*', 75));
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("Результат:");
            Console.WriteLine(new string('*', 75));
            DataService ds = new DataService();
            var res = ds.Calculate();
            Console.WriteLine(res);
            Console.WriteLine(new string('*', 75));
            Console.ReadKey();
        }
    }
}
