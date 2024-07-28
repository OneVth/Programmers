using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(string myString, string pat)
        {
            return new string(myString.Select(w => w == 'A' ? 'B' : 'A').ToArray()).Contains(pat) ? 1 : 0;
        }
    }
}
