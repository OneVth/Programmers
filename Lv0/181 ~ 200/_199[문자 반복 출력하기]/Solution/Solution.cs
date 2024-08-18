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

            foreach (char c in my_string)
                sb.Append(c, n);

            return sb.ToString();
        }
    }
}
