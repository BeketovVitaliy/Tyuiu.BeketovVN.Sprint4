using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BeketovVN.Sprint4.Task3.V1.Lib;

namespace Tyuiu.BeketovVN.Sprint4.Task3.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4| Выполнил: Бекетов В. Н. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил Бекетов В. Н. | ИИПб-23-2                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая считает сумму элементов в последнем столбце *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] myArray = new int[5, 5]
            {
                {3, 4, 3, 4, 1},
                {8, 1, 6, 6, 9},
                {9, 8, 5, 1, 3},
                {1, 8, 7, 1, 2},
                {9, 9, 7, 5, 6}
            };
            int rows = myArray.GetUpperBound(0) + 1;
            int colums = myArray.Length / rows;

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write($"{myArray[i, j]} \t");
                }
                Console.WriteLine();
            }



            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(myArray);
            Console.WriteLine("Сумма элементов в последнем столбце = " + result);
            Console.ReadKey();
        }
    }
}
