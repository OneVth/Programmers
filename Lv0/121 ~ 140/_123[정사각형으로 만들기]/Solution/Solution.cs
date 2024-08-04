using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[,] solution(int[,] arr)
        {
            int rowSize = arr.GetLength(0);
            int colSize = arr.GetLength(1);
            int size = (rowSize > colSize) ? rowSize : colSize;

            int[,] answer = new int[size, size];

            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    answer[i, j] = arr[i, j];
                }
            }

            return answer;
        }
    }
}
