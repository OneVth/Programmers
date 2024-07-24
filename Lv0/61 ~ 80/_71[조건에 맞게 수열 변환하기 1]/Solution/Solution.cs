using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int[] arr)
        {
            List<int> list = new List<int>();

            foreach (int i in arr)
            {
                if (i >= 50 && i % 2 == 0) list.Add(i / 2);
                else if (i < 50 && i % 2 == 1) list.Add(i * 2);
                else list.Add(i);
            }

            return list.ToArray();
        }
    }
}
