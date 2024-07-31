using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution1(int[] arr)
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

        public int[] solution2(int[] arr)
        {
            return arr.Select(s =>
            {
                if (s >= 50 && s % 2 == 0) return s / 2;
                else if (s < 50 && s % 2 == 1) return s * 2;
                else return s;
            }).ToArray();
        }
    }
}
