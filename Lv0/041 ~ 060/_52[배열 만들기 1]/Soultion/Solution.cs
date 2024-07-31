using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soultion
{
    internal class Solution
    {
        public int[] solution1(int n, int k)
        {
            List<int> list = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                if (i % k == 0) list.Add(i);
            }

            return list.ToArray();
        }
        public int[] solution2(int n, int k)
        {
            return Enumerable.Range(1, n).Where(w => w % k == 0).ToArray();
        }
    }
}
