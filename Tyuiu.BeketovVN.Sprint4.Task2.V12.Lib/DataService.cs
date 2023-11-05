using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BeketovVN.Sprint4.Task2.V12.Lib
{
    public class DataService : ISprint4Task2V12
    {
        public int Calculate(int[] array)
        {
            int sum = 0;

            foreach (int element in array)
            {
                if (element % 2 != 0) // Проверяем, что элемент массива нечетный
                {
                    sum += element; // Добавляем его к текущей сумме
                }
            }

            return sum;
        }
    }
}