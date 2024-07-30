using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution1(int[] arr, int n)
        {

            if (arr.Length % 2 == 0)
            {
                for (int i = 1; i < arr.Length; i += 2)
                    arr[i] += n;
            }
            else
            {
                for (int i = 0; i < arr.Length; i += 2)
                    arr[i] += n;
            }

            return arr;
        }

        public int[] solution2(int[] arr, int n)
        {
            int i = 0;

            i = arr.Length % 2 == 0 ? 1 : 0;

            for (; i < arr.Length; i += 2)
                arr[i] += n;

            return arr;
        }
    }
}
