using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int num, int k)
        {
            int tmp = num.ToString().IndexOf(k.ToString());
            return tmp > -1 ? tmp + 1 : -1;
        }
    }
}
