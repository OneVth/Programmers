using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int angle)
        {
            int answer = 0;

            if (90 > angle)
                answer = 1;
            else if (90 == angle)
                answer = 2;
            else if (180 > angle)
                answer = 3;
            else if (180 == angle)
                answer = 4;

            return answer;
        }
    }
}
