using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int[] dot)
        {
            int answer = 0;

            if (0 < dot[0])
            {
                answer = 0 < dot[1] ? 1 : 4;
            }
            else
            {
                answer = 0 > dot[1] ? 3 : 2;
            }

            return answer;
        }
    }
}
