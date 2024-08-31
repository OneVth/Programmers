using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public long[] solution(int x, int n)
        {
            return Enumerable.Range(1, n).Select(s => s * (long)x).ToArray();
        }
    }
}
