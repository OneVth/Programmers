using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(string my_string, string is_prefix)
        {
            List<string> prefix = new List<string>();

            for (int i = 0; i < my_string.Length; i++)
            {
                prefix.Add(my_string.Substring(0, i));
            }

            return prefix.Contains(is_prefix) ? 1 : 0;
        }

        public int solution2(string my_string, string is_prefix)
        {
            return my_string.IndexOf(is_prefix) == 0 ? 1 : 0;
        }
    }
}
