﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.BeketovVN.Sprint4.SprintReview.V6.Lib
{
    public class DataService
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];

            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value.Substring(index, 1));
                    index++;
                }
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        count += matrix[i, j];
                    }
                }
            }

            return count;
        }
    }
}
