using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string my_string, int[,] queries)
        {
            StringBuilder sb = new StringBuilder(my_string);
            int queryCount = queries.GetLength(0);

            for (int i = 0; i < queryCount; i++)
            {
                int s = queries[i, 0];
                int e = queries[i, 1];

                for (int t = 0; t < (e - s + 1) / 2; t++)
                {
                    char temp = sb[e - t];
                    sb[e - t] = sb[s + t];
                    sb[s + t] = temp;
                }
            }
            return sb.ToString();
        }
    }
}
