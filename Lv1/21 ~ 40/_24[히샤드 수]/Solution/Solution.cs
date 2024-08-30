using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public bool solution(int x)
        {
            char[] charArr = x.ToString().ToCharArray();
            int sum = 0;

            foreach (char c in charArr)
                sum += int.Parse(c.ToString());

            return x % sum == 0 ? true : false;
        }
    }
}
