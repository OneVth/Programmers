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

            for (int i = 1; i <= n; i++)
            {
                answer *= i;
                if (answer > n) return i - 1;
            }

            return answer;
        }

        public int solution2(int n)
        {
            int i = 1;
            int factorial = 1;

            while (factorial <= n)
            {
                i++;
                factorial *= i;
            }

            return i - 1;
        }
    }
}
