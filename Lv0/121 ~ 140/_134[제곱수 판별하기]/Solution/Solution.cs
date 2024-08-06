using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int n)
        {
            int sqrt = (int)Math.Sqrt(n);
            return (sqrt * sqrt == n) ? 1 : 2;
        }
    }
}
