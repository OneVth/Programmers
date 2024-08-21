using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int n)
        {
            int answer = 1;

            while (0 != (6 * answer % n))
                answer++;

            return answer;
        }
    }
}
