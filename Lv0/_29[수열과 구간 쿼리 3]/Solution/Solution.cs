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
            int queryCount = queries.GetLength(0);

            for (int i = 0; i < queryCount; i++)
            {
                int index1 = queries[i, 0];
                int index2 = queries[i, 1];

                int temp = arr[index1];
                arr[index1] = arr[index2];
                arr[index2] = temp;
            }

            return arr;
        }
    }
}
