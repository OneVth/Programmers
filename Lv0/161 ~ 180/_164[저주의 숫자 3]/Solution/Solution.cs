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

            for (int i = 0; i < n; i++)
            {
                ++answer;
                while (answer.ToString().Contains('3') || (answer % 3 == 0))
                    ++answer;
            }

            return answer;
        }
    }
}
