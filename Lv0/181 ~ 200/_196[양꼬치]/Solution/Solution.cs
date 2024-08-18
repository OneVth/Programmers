using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int n, int k)
        {
            return n * 12000 + (k - n / 10) * 2000;
        }
    }
}
