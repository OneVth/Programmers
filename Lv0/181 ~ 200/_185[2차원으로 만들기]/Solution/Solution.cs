using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[,] solution1(int[] num_list, int n)
        {
            int nRow = num_list.Length / n;
            int nCol = n;
            int[,] answer = new int[nRow, nCol];

            for (int i = 0; i < nRow; i++)
            {
                for (int j = 0; j < nCol; j++)
                {
                    answer[i, j] = num_list[i * n + j];
                }
            }

            return answer;
        }

        public int[][] solution2(int[] num_list, int n)
        {
            int rows = num_list.Length / n;
            int[][] result = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                result[i] = new int[n];
                for (int j = 0; j < n; j++)
                    result[i][j] = num_list[i * n + j];
            }
            return result;
        }
    }
}
