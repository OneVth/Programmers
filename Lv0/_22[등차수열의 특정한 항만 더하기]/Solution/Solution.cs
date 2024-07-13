using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int a, int d, bool[] included)
        {
            int answer = 0;

            for (int i = 0; i < included.Length; i++)
            {
                answer += included[i] ? a + i * d : 0;
            }
            return answer;
        }
    }
}
