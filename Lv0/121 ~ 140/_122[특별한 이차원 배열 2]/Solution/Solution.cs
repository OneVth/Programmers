using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int[,] arr)
        {
            int size = arr.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                for (int j = i; j < size; j++)
                {
                    if (arr[i, j] != arr[j, i])
                        return 0;
                }
            }

            return 1;
        }
    }
}
