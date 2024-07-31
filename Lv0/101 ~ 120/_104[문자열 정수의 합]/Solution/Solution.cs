using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(string num_str)
        {
            int answer = 0;

            foreach (char c in num_str)
            {
                answer += (int)(c - '0');
            }

            return answer;
        }

        public int solution2(string num_str)
        {
            return num_str.Select(s => s - '0').Sum();
        }
    }
}
