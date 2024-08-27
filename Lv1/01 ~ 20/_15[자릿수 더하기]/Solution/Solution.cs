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

            foreach (char c in n.ToString())
                answer += int.Parse(c.ToString());

            return answer;
        }
    }
}
