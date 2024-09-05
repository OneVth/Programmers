using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int[] absolutes, bool[] signs)
        {
            int answer = 0;

            for (int i = 0; i < signs.Length; i++)
            {
                answer += signs[i] ? absolutes[i] : -absolutes[i];
            }

            return answer;
        }
    }
}
