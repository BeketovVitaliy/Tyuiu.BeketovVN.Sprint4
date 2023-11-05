using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BeketovVN.Sprint4.Task0.V23.Lib
{
    public class DataService : ISprint4Task0V23
    {
        public int GetMultOddArrEl(int[] array)
        {
            int product = 1;

            foreach (int element in array)
            {
                if (element % 2 != 0) // Проверяем, что элемент массива нечетный
                {
                    product *= element; // Умножаем его на текущее произведение
                }
            }

            return product;
        }
    }
}
