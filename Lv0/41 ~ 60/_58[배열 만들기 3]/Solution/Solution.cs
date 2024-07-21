using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int[] arr, int[,] intervals)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < intervals.GetLength(0); i++)
            {
                int start = intervals[i, 0];
                int end = intervals[i, 1];

                for (int j = start; j <= end; j++)
                    list.Add(arr[j]);
            }
            return list.ToArray();
        }
    }
}
