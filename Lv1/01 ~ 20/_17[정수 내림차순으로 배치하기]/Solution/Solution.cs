using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public long solution(long n)
        {
            StringBuilder sb = new StringBuilder();
            string tmp;

            while (n != 0)
            {
                sb.Append(n % 10);
                n /= 10;
            }

            tmp = sb.ToString();
            char[] tmpArray = tmp.ToCharArray();

            Array.Sort(tmpArray);
            Array.Reverse(tmpArray);
            return long.Parse(new string(tmpArray));
        }
    }
}
