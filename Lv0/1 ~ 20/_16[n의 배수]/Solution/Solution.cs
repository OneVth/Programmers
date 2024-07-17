using System;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    internal class Solution
    {
        public int solution(int num, int n)
        {
            int answer = 0;
            answer = num % n == 0 ? 1 : 0;
            return answer;
        }
    }
}
