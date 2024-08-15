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
        public string solution1(string my_string)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            return new string(my_string.Where(w => !vowels.Contains(w)).ToArray());
        }

        public string solution2(string my_string) 
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            foreach (char c in vowels)
            {
                my_string = my_string.Replace(c.ToString(), "");
            }
            return my_string; 
        }

        public string solution3(string my_string)
        {
            return Regex.Replace(my_string, @"a|e|i|o|u", "");
        }
    }
}
