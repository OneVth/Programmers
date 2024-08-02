using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int a, int b)
        {
            int answer = 0;

            if (a % 2 == 1 && b % 2 == 1)
                answer = a * a + b * b;
            else if (a % 2 == 1 || b % 2 == 1)
                answer = 2 * (a + b);
            else
                answer = Math.Abs(a - b);

            return answer;
        }

        public int solution2(int a, int b)
        {
            int oddCount = 0;
            if (a % 2 == 1) ++oddCount;
            if (b % 2 == 1) ++oddCount;

            if (oddCount == 2)
                return a * a + b * b;
            else if (oddCount == 1)
                return 2 * (a + b);
            else
                return Math.Abs(a - b);
        }
    }
}
