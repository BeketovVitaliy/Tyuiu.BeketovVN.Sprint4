using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BeketovVN.Sprint4.Task1.V7.Lib
{
    public class DataService : ISprint4Task1V7
    {
        public int Calculate(int[] array)
        {
            int sum = 0;

            foreach (int element in array)
            {
                if (element % 2 == 0) // Проверяем, что элемент массива четный
                {
                    sum += element; // Добавляем его к текущей сумме
                }
            }

            return sum;
        }
    }
}
