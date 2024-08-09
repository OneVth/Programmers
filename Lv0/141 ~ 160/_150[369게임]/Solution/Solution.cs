using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int order)
        {
            int answer = 0;

            foreach (char c in order.ToString())
            {
                int tmp = int.Parse(c.ToString());
                if ((0 != tmp) && (tmp % 3 == 0))
                    answer++;
            }

            return answer;
        }

        public int solution2(int order)
        {
            return order.ToString().Count(x => x == '3' || x == '6' || x == '9');
        }
    }
}
