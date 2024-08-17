using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int balls, int share)
        {
            double numerator = 1, denominator = 1;

            // n! / (n - m)! * m!
            for (int i = 0; i < balls - share; i++)
                numerator *= balls - i;

            for (int i = 0; i < balls - share; i++)
                denominator *= balls - share - i;
            return (int)(numerator / denominator);
        }
    }
}
