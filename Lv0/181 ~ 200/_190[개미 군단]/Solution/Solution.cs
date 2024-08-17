using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int hp)
        {
            int answer = 0;
            answer += hp / 5;
            answer += hp % 5 / 3;
            answer += hp % 5 % 3;
            return answer;
        }
    }
}
