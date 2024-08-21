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
            int answer = 1;

            while (0 != (6 * answer % n))
                answer++;

            return answer;
        }

        public int solution2(int n)
        {
            return LCM(n, 6) / 6;
        }

        private int GCD(int a, int b)
        {
            while (0 != b)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }
    }
}
