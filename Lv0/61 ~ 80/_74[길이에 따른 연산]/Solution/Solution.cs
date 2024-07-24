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
            int answer = 1;

            if (num_list.Length >= 11) return num_list.Sum();
            else
            {
                foreach (int i in num_list)
                {
                    answer *= i;
                }
            }
            return answer;
        }
    }
}
