using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(string num_str)
        {
            int answer = 0;

            foreach (char c in num_str)
            {
                answer += (int)(c - '0');
            }

            return answer;
        }
    }
}
