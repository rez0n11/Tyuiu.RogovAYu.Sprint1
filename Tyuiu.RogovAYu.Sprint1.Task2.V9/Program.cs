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


            int a = 6, b = 4;

            int x = 30 / 6 + 4;

            a++;

            x += b += a;
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}

