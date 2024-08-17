using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int hp)
        {
            int answer = 0;
            answer += hp / 5;
            answer += hp % 5 / 3;
            answer += hp % 5 % 3;
            return answer;
        }

        public int solution2(int hp)
        {
            int answer = 0;
            answer += hp / 5;
            hp = hp % 5;

            answer += hp / 3;
            hp = hp % 3;

            answer += hp;
            return answer;
        }
    }
}
