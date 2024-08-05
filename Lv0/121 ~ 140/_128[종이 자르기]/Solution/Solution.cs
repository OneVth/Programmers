using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int M, int N)
        {
            return (M - 1) + M * (N - 1);
        }
        public int solution2(int M, int N)
        {
            return M * N - 1;
        }
    }
}
