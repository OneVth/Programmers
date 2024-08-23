using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int n)
        {
            return Enumerable.Range(1, n).Where(w => w % 2 != 0).ToArray();
        }
    }
}
