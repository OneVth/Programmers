using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(string str1, string str2)
        {
            return str2.Contains(str1) ? 1 : 0;
        }

        public int solution2(string str1, string str2)
        {
            return str2.IndexOf(str1) >= 0 ? 1 : 0;
        }
    }
}
