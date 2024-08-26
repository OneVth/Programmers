using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public bool solution1(string s)
        {
            if (s.Length != 4 && s.Length != 6)
                return false;

            return int.TryParse(s, out int result);
        }

        public bool solution2(string s)
        {
            bool answer = false;

            if (s.Length == 4 || s.Length == 6)
                answer = Regex.IsMatch(s, @"^\d+$");

            return answer;
        }
    }
}
