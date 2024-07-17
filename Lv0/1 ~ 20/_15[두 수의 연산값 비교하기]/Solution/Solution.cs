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

            int num1 = int.Parse($"{a}{b}");
            int num2 = 2 * a * b;

            answer = Math.Max(num1, num2);
            return answer;
        }
    }
}
