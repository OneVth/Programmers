using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution1(int[] numlist, int n)
        {
            return numlist.OrderByDescending(o => o).OrderBy(o => Math.Abs(o - n)).ToArray();
        }

        public int[] solution2(int[] numlist, int n)
        {
            return numlist.OrderBy(x => Math.Abs(n - x)).ThenByDescending(x => x).ToArray();
        }
    }
}
