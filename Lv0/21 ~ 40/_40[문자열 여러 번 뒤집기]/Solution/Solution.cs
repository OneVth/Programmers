using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution1(string my_string, int[,] queries)
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

        public string solution2(string my_string, int[,] queries)
        {
            var arr = my_string.ToCharArray();
            for(int y = 0; y < queries.GetLength(0); ++y)
            {
                int s = queries[y, 0];
                int e = queries[y, 1];

                Array.Reverse(arr, s, e - s + 1);
            }
            return new string(arr);
        }
    }
}
