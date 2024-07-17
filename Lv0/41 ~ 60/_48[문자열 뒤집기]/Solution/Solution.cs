using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string my_string, int s, int e)
        {
            char[] chars = my_string.ToCharArray();

            Array.Reverse(chars, s, e - s + 1);

            return new string(chars);
        }
    }
}
