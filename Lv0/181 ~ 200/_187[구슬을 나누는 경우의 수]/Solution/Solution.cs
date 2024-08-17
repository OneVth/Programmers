using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int balls, int share)
        {
            double numerator = 1, denominator = 1;

            // n! / (n - m)! * m!
            for (int i = 0; i < balls - share; i++)
                numerator *= balls - i;

            for (int i = 0; i < balls - share; i++)
                denominator *= balls - share - i;
            return (int)(numerator / denominator);
        }

        public int solution2(int balls, int share)
        {
            long answer = 1;

            for(int i = 0; i < balls - share; i++)
            {
                answer = answer * (balls - i) / (i + 1);
            }
            return (int)answer;
        }

    }
}
