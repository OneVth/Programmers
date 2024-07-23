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

            int oddSum = num_list.Where((w, index) => index % 2 == 0).Sum();
            int evenSum = num_list.Where((w, index) => index % 2 == 1).Sum();

            return oddSum >= evenSum ? oddSum : evenSum;
        }
    }
}
