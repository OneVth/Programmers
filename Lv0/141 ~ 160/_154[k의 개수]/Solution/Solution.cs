using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int i, int j, int k)
        {
            int answer = 0;

            for (; i <= j; i++)
            {
                answer += i.ToString().Count(c => c == '0' + k);
            }

            return answer;
        }
    }
}
