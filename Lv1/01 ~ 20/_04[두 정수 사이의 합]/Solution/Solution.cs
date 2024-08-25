using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public long solution1(int a, int b)
        {
            long answer = 0;
            int min = a < b ? a : b;
            int max = a <= b ? b : a;

            for (int i = min; i <= max; i++)
                answer += i;
            return answer;
        }

        public long solution2(int a, int b)
        {
            long answer = 0;

            while (a != b)
            {
                answer += a;
                a = (a > b) ? a - 1 : a + 1;
            }

            return answer + b;
        }

        public long solution3(int a, int b) 
        {
            // 등차수열의 합
            return (((long)Math.Abs(a - b) + 1) * (a + b)) / 2; 
        }
    }
}
