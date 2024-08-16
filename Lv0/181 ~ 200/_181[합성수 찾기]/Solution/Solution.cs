using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int n)
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
                        Console.WriteLine(i);
                        answer++;
                        break;
                    }
                }
            }

            return answer;
        }
    }
}
