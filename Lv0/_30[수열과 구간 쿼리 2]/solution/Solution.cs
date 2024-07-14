using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solution
{
    internal class Solution
    {
        public int[] solution(int[] arr, int[,] queries)
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

        
    }
}
