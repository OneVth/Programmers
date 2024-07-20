using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soultion
{
    internal class Solution
    {
        public int solution1(int[] arr, int idx)
        {

            for (int i = idx; i < arr.Length; i++)
            {
                if (arr[i] == 1) return i;
            }

            return -1;
        }

        public int solution2(int[] arr, int idx)
        {
            return Array.FindIndex(arr, idx, arr.Length - idx, index => index == 1);
        }
    }
}
