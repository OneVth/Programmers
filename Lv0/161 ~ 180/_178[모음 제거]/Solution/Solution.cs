using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string my_string)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            return new string(my_string.Where(w => !vowels.Contains(w)).ToArray());
        }
    }
}
