using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solution
{
    internal class Solution
    {
        public int[] solution1(int[] arr, int[,] queries)
        {

            int queryCount = queries.GetLength(0);
            int[] answer = new int[queryCount];

            for (int i = 0; i < queryCount; i++)
            {
                int s = queries[i, 0];
                int e = queries[i, 1];
                int k = queries[i, 2];
                int[] temp = new int[e - s + 1];

                for (int j = s, t = 0; j <= e; j++, t++)
                {
                    temp[t] = arr[j];
                }

                var filteredTemp = temp.Where(n => n > k).ToArray();
                answer[i] = filteredTemp.Length == 0 ? -1 : filteredTemp.Min();
            }

            return answer;
        }

        public int[] solution2(int[] arr, int[,] queries)
        {
            int[] answer = new int[queries.GetLength(0)];
            for (int i = 0; i < queries.GetLength(0); i++)
            {
                int s = queries[i, 0];
                int e = queries[i, 1];
                int k = queries[i, 2];

                int num = arr.Skip(s)
                    .Take(e - s + 1)
                    .Where(w => w > k)
                    .DefaultIfEmpty(-1)
                    .OrderBy(o => o)
                    .First();

                answer[i] = num;
            }
            return answer;
        }
    }
}
