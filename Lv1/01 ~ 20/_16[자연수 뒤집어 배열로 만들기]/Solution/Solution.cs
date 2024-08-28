using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(long n)
        {
            List<int> list = new List<int>();

            while (n != 0)
            {
                list.Add((int)(n % 10));
                n /= 10;
            }

            return list.ToArray();
        }
    }
}
