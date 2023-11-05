using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BeketovVN.Sprint4.Task1.V7.Lib;

namespace Tyuiu.BeketovVN.Sprint4.Task1.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4| Выполнил: Бекетов В. Н. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил Бекетов В. Н. | ИИПб-23-2                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая считает сумму четных элементов массива.     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len;
            Console.Write("Введите количество элементов в массиве: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i <= numsArray.Length - 1; i++)
            {
                Console.WriteLine("Введите значение " + i + " элемента массива: ");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= numsArray.Length - 1; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(numsArray);
            Console.WriteLine("Сумма четных элементов массива = " + result);
            Console.ReadKey();
        }
    }
}
