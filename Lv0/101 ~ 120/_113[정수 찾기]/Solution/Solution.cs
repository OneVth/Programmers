using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int[] num_list, int n)
        {
            return Array.IndexOf(num_list, n) >= 0 ? 1 : 0;
        }

        public int solution2(int[] num_list, int n)
        {
            return Array.FindIndex(num_list, b => b == n) == -1 ? 0 : 1;
        }
    }
}
