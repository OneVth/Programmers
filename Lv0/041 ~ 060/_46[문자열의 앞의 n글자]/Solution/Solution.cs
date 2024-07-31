using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution1(string my_string, int n)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(my_string.Substring(0, n));

            return sb.ToString();
        }

        public string solution2(string my_string, int n)
        {
            return my_string.Length == n ? my_string : my_string.Remove(n);
        }
    }
}
