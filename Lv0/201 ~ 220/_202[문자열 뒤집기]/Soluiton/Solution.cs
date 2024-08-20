using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soluiton
{
    internal class Solution
    {
        public string solution(string my_string)
        {
            char[] reversed = my_string.ToCharArray();
            Array.Reverse(reversed);
            return new string(reversed);
        }
    }
}
