using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BeketovVN.Sprint4.Task7.V25.Lib
{
    public class DataService : ISprint3Task7V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            string inputString = "348561792486";

            // Преобразуем строку в матрицу 4 на 3
            double[] result = new double[12];
            for (int i = 0; i < inputString.Length; i++)
            {
                int digit = int.Parse(inputString[i].ToString());
                result[i] = digit;
            }

            // Подсчитываем сумму четных чисел
            double sumOfEvens = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] % 2 == 0)
                {
                    sumOfEvens += result[i];
                }
            }

            // Возвращаем результат, включая сумму четных чисел
            result[0] = sumOfEvens;
            return result;  
        }
    }
}
