using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int[] arr, int[] query)
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
    }
}
