using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int[] num_list)
        {
            int answer = 0;

            foreach (int i in num_list)
            {
                int temp = i;
                while (temp != 1)
                {
                    if (temp % 2 == 0) temp /= 2;
                    else temp = (temp - 1) / 2;
                    answer++;
                }
            }

            return answer;
        }
    }
}
