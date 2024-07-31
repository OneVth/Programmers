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
                for (int j = 0; j < i; j++) list.Add(i);
            }
            return list.ToArray();
        }

        public int[] solution2(int[] arr)
        {
            List<int> answer = new List<int>();
            foreach (int n in arr)
                answer.AddRange(Enumerable.Repeat(n, n));
            return answer.ToArray();
        }
    }
}
