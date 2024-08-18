using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution1(int[] emergency)
        {
            List<int> list = new List<int>();
            var temp = emergency.OrderByDescending(o => o).ToArray();

            for (int i = 0; i < temp.Length; i++)
                list.Add(Array.IndexOf(temp, emergency[i]) + 1);

            return list.ToArray();
        }

        public int[] solution2(int[] emergency)
        {
            int[] ordered = emergency.OrderByDescending(o => o).ToArray();
            return emergency.Select(s => Array.IndexOf(ordered, s) + 1).ToArray();
        }
    }
}
