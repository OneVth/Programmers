using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[,] solution(int n)
        {
            int[,] answer = new int[n, n];

            int x = -1, y = 0;
            int nDirection = 1;
            int cnt = 0;

            for (int i = n; i > 0; i--)
            {
                for (int j = 0; j < (2 * i - 1); j++)
                {
                    if (i > j)
                        x += nDirection;
                    else
                        y += nDirection;

                    answer[y, x] = ++cnt;
                }
                nDirection = -nDirection;
            }

            return answer;
        }
    }
}
