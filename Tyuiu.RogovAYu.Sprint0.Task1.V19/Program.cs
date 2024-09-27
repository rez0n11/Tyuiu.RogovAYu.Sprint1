using System;
using Tyuiu.RogovAYu.Sprint1.Task1.V19.Lib;

namespace Tyuiu.RogovAYu.Sprint1.Task1.V19
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            Console.Title = "Task:1.1.v19| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* Спринт #1");
            Console.WriteLine("* Задание #1");
            Console.WriteLine("* Вариант #19");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1");
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("Исходные данные:");
            //code
            double x=Convert.ToDouble( Console.ReadLine());
            double y =Convert.ToDouble( Console.ReadLine());
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("Результат:");
            Console.WriteLine(new string('*', 75));
            //result
            DataService ds = new DataService();
            var res = ds.Calculate(x,y);
            Console.WriteLine(res);

            Console.WriteLine(new string('*', 75));
            Console.ReadKey();
        }
    }
}
