using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int n, int t)
        {
            return (int)(n * Math.Pow(2, t));
        }

        public int solution2(int n, int t)
        {
            return n << t;
        }
    }
}
