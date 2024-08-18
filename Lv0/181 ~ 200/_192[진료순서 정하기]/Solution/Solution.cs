using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int[] emergency)
        {
            List<int> list = new List<int>();
            var temp = emergency.OrderByDescending(o => o).ToArray();

            for (int i = 0; i < temp.Length; i++)
                list.Add(Array.IndexOf(temp, emergency[i]) + 1);

            return list.ToArray();
        }
    }
}
