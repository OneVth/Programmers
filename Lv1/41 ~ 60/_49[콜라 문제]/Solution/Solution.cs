using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int a, int b, int n)
        {
            int answer = 0;

            while (n >= a)
            {
                int temp = n / a * b;
                n = n % a + temp;

                answer += temp;
            }
            return answer;
        }
    }
}
