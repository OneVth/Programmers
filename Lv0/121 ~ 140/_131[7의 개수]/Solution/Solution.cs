using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int[] array)
        {
            int answer = 0;
            foreach (int n in array)
            {
                string s = n.ToString();
                foreach (char c in s)
                {
                    if (c == '7') answer++;
                }
            }
            return answer;
        }
    }
}
