using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int[] numlist, int n)
        {
            return numlist.OrderByDescending(o => o).OrderBy(o => Math.Abs(o - n)).ToArray();
        }
    }
}
