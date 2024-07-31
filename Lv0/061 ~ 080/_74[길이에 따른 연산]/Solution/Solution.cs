using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int[] num_list)
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

        public int solution2(int[] num_list)
        {
            int answer = num_list.Length <= 10 ? num_list.Aggregate((a, b) => a * b) : num_list.Sum();

            return answer;
        }
    }
}
