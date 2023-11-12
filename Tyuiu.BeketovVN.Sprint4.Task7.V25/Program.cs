using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BeketovVN.Sprint4.Task7.V25.Lib;

namespace Tyuiu.BeketovVN.Sprint4.Task7.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4| Выполнил: Бекетов В. Н. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил Бекетов В. Н. | ИИПб-23-2                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая считает произведение четных элементов.      *");
            Console.WriteLine("* меньше 8.                                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 3;
            int stopValue = 4;
            double[,] mtrx = new double[startValue, stopValue];

            string str = "348561792486";
            int index = 0;
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < startValue; i++)
            {
                for (int j = 0; j < stopValue; j++)
                {
                    Console.WriteLine($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double[] res = ds.GetMassFunction(startValue, stopValue);
            Console.WriteLine("Произведение четных элементов = " + res[0]);
            Console.ReadKey();
        }
    }
}
