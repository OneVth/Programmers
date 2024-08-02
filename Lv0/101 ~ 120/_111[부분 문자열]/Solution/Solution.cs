using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(string str1, string str2)
        {
            return str2.Contains(str1) ? 1 : 0;
        }
    }
}
