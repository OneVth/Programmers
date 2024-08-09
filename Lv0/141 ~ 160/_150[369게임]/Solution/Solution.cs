using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int order)
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
    }
}
