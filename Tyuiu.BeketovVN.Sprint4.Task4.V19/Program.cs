using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BeketovVN.Sprint4.Task4.V19.Lib;

namespace Tyuiu.BeketovVN.Sprint4.Task4.V19
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
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил Бекетов В. Н. | ИИПб-23-2                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найдите сумму нечетных элементов массива.                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] myArray = new int[5, 5]
{
                { 6, 7, 3, 5, 1 },
                { 6, 5, 2, 2, 7 },
                { 2, 6, 4, 6, 6 },
                { 7, 5, 5, 2, 6 },
                { 3, 1, 5, 7, 7 }
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
            Console.WriteLine("Сумма нечетных элементов массива = " + result);
            Console.ReadKey();
        }
    }
}
