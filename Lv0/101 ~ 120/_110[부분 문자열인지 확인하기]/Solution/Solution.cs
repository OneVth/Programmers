using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(string my_string, string target)
        {
            return my_string.Contains(target) ? 1 : 0;
        }
    }
}
