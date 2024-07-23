using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int[] numbers, int n)
        {
            int answer = 0;
            int i = 0;

            while (answer <= n)
            {
                answer += numbers[i];
                i++;
            }

            return answer;
        }
    }
}
