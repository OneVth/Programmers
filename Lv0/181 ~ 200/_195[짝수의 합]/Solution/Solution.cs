using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int n)
        {
            int answer = 0;
            for (int i = 2; i <= n; i += 2)
                answer += i;
            return answer;
        }
    }
}
