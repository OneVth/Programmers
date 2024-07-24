using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(string myString, string pat)
        {
            if (pat.Length > myString.Length) return 0;

            return myString.ToUpper().Contains(pat.ToUpper()) ? 1 : 0;
        }

        public int solution2(string myString, string pat)
        {
            return myString.ToUpper().IndexOf(pat.ToUpper()) == -1 ? 0 : 1;
        }
    }
}
