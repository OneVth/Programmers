using System;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    internal class Solution
    {
        public int solution(int a, int b, bool flag)
        {
            int answer = 0;
            answer = flag ? a + b : a - b;
            return answer;
        }
    }
}
