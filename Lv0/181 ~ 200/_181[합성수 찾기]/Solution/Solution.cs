using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int n)
        {
            int answer = 0;

            for (int i = 1; i <= n; i++)
            {
                int nDivisor = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        nDivisor++;

                    if (nDivisor >= 3)
                    {
                        answer++;
                        break;
                    }
                }
            }

            return answer;
        }

        public int solution2(int n)
        {
            int answer = 0;

            for (int i = 4; i <= n; i++)
            {
                answer += Enumerable.Range(1, n).Count(x => i % x == 0) >= 3 ? 1 : 0;
            }
            return answer;
        }
    }
}
