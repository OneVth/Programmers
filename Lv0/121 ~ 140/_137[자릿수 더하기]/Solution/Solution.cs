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
            int answer = 0;

            foreach (char c in n.ToString())
            {
                int temp = int.Parse(c.ToString());
                answer += temp;
            }

            return answer;
        }

        public int solution2(int n)
        {
            return n.ToString().Sum(x => int.Parse(x.ToString()));
        }
    }
}
