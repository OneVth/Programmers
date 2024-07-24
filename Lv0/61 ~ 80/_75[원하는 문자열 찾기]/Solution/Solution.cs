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

            if (pat.Length > myString.Length) return 0;

            return myString.ToUpper().Contains(pat.ToUpper()) ? 1 : 0;
        }
    }
}
