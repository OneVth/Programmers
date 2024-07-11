using System;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    internal class Solution
    {
        public int solution(int a, int b)
        {
            int answer = 0;

            string sA = a.ToString();
            string sB = b.ToString();

            int ab = int.Parse(sA + sB);
            int ba = int.Parse(sB + sA);

            answer = (ab >= ba) ? ab : ba;
            return answer;
        }
    }
}
