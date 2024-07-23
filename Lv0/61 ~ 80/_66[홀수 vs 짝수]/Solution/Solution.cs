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

            int oddSum = num_list.Where((w, index) => index % 2 == 0).Sum();
            int evenSum = num_list.Where((w, index) => index % 2 == 1).Sum();

            return oddSum >= evenSum ? oddSum : evenSum;
        }

        public int solution2(int[] num_list)
        {
            int even = 0;
            for (int i = 0; i < num_list.Length; i += 2)
                even += num_list[i];

            int odd = 0;
            for (int i = 1; i < num_list.Length; i += 2)
                odd += num_list[i];

            return Math.Max(even, odd);
        }
    }
}
