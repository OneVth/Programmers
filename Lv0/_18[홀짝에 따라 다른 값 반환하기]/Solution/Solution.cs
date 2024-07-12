using System;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int n)
        {
            int answer = 0;

            if (n % 2 == 0)
            {
                for (int i = 0; i <= n; i += 2)
                {
                    answer += i * i;
                }
            }
            else
            {
                for (int i = 1; i <= n; i += 2)
                {
                    answer += i;
                }
            }

            return answer;
        }

        public int solution2(int n)
        {
            int answer = 0;
            while(n >= 0)
            {
                answer += n % 2 == 0 ? n * n : n;
                n -= 2;
            }
            return answer;
        }
    }
}
