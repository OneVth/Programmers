using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution1(int[] arr, int k)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (k % 2 == 0) arr[i] += k;
                else arr[i] *= k;
            }

            return arr;
        }

        public int[] solution2(int[] arr, int k)
        {
            if (k % 2 == 1)
                return arr.Select(s => s * k).ToArray();
            else
                return arr.Select(s => s + k).ToArray();
        }
    }
}
