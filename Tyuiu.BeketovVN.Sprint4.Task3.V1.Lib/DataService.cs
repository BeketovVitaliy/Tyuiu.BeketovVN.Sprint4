using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BeketovVN.Sprint4.Task3.V1.Lib
{
    public class DataService : ISprint4Task3V1
    {
        public int Calculate(int[,] array)
        {
            int rowCount = array.GetLength(0);
            int sum = 0;

            for (int i = 0; i < rowCount; i++)
            {
                sum += array[i, rowCount - 1]; // rowCount - 1 - индекс последнего столбца
            }

            return sum;
        }
    }
}
