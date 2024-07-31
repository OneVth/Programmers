using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int[] arr, int[,] queries)
        {

            for (int i = 0; i < queries.GetLength(0); i++)
            {
                int s = queries[i, 0];
                int e = queries[i, 1];

                for (int j = s; j <= e; j++) arr[j]++;
            }

            return arr;
        }
    }
}
