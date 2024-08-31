using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[,] solution1(int[,] arr1, int[,] arr2)
        {
            int rowSize = arr1.GetLength(0);
            int colSize = arr1.GetLength(1);
            int[,] answer = new int[rowSize, colSize];

            for (int i = 0; i < rowSize; i++)
                for (int j = 0; j < colSize; j++)
                    answer[i, j] = arr1[i, j] + arr2[i, j];

            return answer;
        }

        public int[,] solution2(int[,] arr1, int[,] arr2)
        {
            int[,] answer = (int[,])arr1.Clone();
            for (int i = 0; i < arr1.GetLength(0); i++)
                for (int j = 0; j < arr2.GetLength(1); j++)
                    answer[i, j] += arr2[i, j];

            return answer;
        }
    }
}
