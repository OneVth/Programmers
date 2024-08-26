using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public bool solution(string s)
        {
            if (s.Length != 4 && s.Length != 6)
                return false;

            return int.TryParse(s, out int result);
        }
    }
}
