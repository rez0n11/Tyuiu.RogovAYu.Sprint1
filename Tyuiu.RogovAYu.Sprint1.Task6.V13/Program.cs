using System;
using Tyuiu.RogovAYu.Sprint1.Task6.V13.Lib;

namespace Tyuiu.RogovAYu.Sprint1.Task6.V13
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            bool result;

            Console.Title = "Task:1.6.v13| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:Написать программу: пользователь вводит текст.                  *");
            Console.WriteLine("               Проверить, что буквы строки упорядочены по алфавиту.       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("* ");
            string input = Console.ReadLine();
            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.CheckWordsAlphabet(input);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
