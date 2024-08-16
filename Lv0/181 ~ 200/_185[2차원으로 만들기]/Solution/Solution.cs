using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[,] solution(int[] num_list, int n)
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
    }
}
