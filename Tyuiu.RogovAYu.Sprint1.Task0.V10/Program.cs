using System;

namespace Tyuiu.RogovAYu.Sprint1.Task3.V10
{
    public class Class1
    {
        public static void Main()
        {
            
            string result;

            Console.Title = "Task:1.3.v10| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Условие: преобразовать введенное с клавиатуры число в денежный формат     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            double input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");

            { //code
                result = $"{Math.Truncate(input)} руб. {Convert.ToInt32(Math.Round(input % Math.Truncate(input),2)*100)} коп.";
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* = {result}                                                 ");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
