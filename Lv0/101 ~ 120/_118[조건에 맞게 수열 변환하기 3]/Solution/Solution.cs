using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int[] arr, int k)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (k % 2 == 0) arr[i] += k;
                else arr[i] *= k;
            }

            return arr;
        }
    }
}
