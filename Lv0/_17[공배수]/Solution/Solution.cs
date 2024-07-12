using System;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int number, int n, int m)
        {
            int answer = 0;

            if (number % n == 0)
                if (number % m == 0)
                    answer = 1;

            return answer;
        }

        public int solution2(int number, int n, int m)
        {
            int answer = 0;

            if (number % n == 0 && number % m == 0)
                answer = 1;

            return answer;
        }
    }
}
