using System;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int a, int b)
        {
            int answer = 0;

            string sA = a.ToString();
            string sB = b.ToString();

            int ab = int.Parse(sA + sB);
            int ba = int.Parse(sB + sA);

            answer = (ab >= ba) ? ab : ba;
            return answer;
        }

        public int solution2(int a, int b)
        {
            int aNum = int.Parse($"{a}{b}");
            int bNum = int.Parse($"{b}{a}");

            return Math.Max(aNum, bNum);
        }
    }
}
