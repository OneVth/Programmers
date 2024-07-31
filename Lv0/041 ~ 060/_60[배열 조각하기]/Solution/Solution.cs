using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution1(int[] arr, int[] query)
        {

            for (int i = 0; i < query.Length; i++)
            {
                if (i % 2 == 0)
                    arr = arr.Take(query[i] + 1).ToArray();
                else
                    arr = arr.Skip(query[i]).ToArray();
            }

            return arr;
        }

        public int[] solution2(int[] arr, int[] query) {
            int start = 0;
            int end = arr.Length - 1;
            for(int i = 0; i < query.Length; i++)
            {
                if (i % 2 == 0)
                    end = start + query[i] - 1;
                else
                    start = start + query[i];
            }

            if (start > end) return new int[1] { -1 };
            return arr.Skip(start).Take(end - start + 1).ToArray();
    }
}
