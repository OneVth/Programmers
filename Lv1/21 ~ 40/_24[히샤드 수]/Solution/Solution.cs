using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public bool solution1(int x)
        {
            char[] charArr = x.ToString().ToCharArray();
            int sum = 0;

            foreach (char c in charArr)
                sum += int.Parse(c.ToString());

            return x % sum == 0 ? true : false;
        }

        public bool solution2(int x)
        {
            int temp = x.ToString().Select(s => int.Parse(s.ToString())).Sum();

            return x % temp == 0 ? true : false;
        }
    }
}
