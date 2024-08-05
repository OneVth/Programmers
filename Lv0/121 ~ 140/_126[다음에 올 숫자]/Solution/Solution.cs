using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int[] common)
        {
            int answer = 0;
            int d = 0;

            if ((common[2] - common[1]) == (common[1] - common[0]))
            {
                d = common[1] - common[0];
                answer = common.Last() + d;
            }
            else
            {
                d = common[1] / common[0];
                answer = common.Last() * d;
            }

            return answer;
        }
    }
}
