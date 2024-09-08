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
            for (int i = 2; i < n; i++)
            {
                if (n % i == 1)
                    return i;
            }
            return 0;
        }
    }
}
