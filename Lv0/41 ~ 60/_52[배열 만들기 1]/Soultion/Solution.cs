using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soultion
{
    internal class Solution
    {
        public int[] solution(int n, int k)
        {
            List<int> list = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                if (i % k == 0) list.Add(i);
            }

            return list.ToArray();
        }
    }
}
