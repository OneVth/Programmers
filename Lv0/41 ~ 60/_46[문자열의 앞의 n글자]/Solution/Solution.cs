using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string my_string, int n)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(my_string.Substring(0, n));

            return sb.ToString();
        }
    }
}
