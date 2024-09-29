using System;
using Tyuiu.RogovAYu.Sprint1.Task5.V3.Lib;

namespace Tyuiu.RogovAYu.Sprint1.Task5.V3
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            int result; 

            Console.Title = "Task:1.5.v3| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:Присвоить целой переменной h третью от конца цифру              *\n*                      в записи положительного целого числа k             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("* k = ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.Calculate(input);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* h = {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
