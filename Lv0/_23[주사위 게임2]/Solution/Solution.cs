using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int a, int b, int c)
        {
            int answer = 0;

            if (a == b && b == c)
                answer = (a + b + c) * (a * a + b * b + c * c) * (a * a * a + b * b * b + c * c * c);
            else if ((a == b && b != c) || (a == c && a != b) || (b == c && c != a))
                answer = (a + b + c) * (a * a + b * b + c * c);
            else
                answer = a + b + c;

            return answer;
        }
    }
}
