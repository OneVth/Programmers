using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[,] solution1(int n)
        {
            int[,] answer = new int[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (i == j) answer[i, j] = 1;

            return answer;
        }

        public int[,] solution2(int n)
        {
            int[,] answer = new int[n, n];

            for (int i = 0; i < n; i++)
                answer[i, i] = 1;

            return answer;
        }
    }
}
