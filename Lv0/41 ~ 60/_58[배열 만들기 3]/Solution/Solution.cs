using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution1(int[] arr, int[,] intervals)
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

        public int[] solution2(int[] arr, int[,] intervals)
        {
            int size1 = intervals[0, 1] - intervals[0, 0] + 1;
            int size2 = intervals[1, 1] - intervals[1, 0] + 1;

            int[] answer = new int[size1 + size2];
            Array.Copy(arr, intervals[0, 0], answer, 0, size1);
            Array.Copy(arr, intervals[1, 0], answer, size1, size2);

            return answer;
        }
    }
}
