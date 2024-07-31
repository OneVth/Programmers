using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int[] arr1, int[] arr2)
        {

            if (arr1.Length != arr2.Length)
                return arr1.Length > arr2.Length ? 1 : -1;
            else
            {
                if (arr1.Sum() != arr2.Sum())
                    return arr1.Sum() > arr2.Sum() ? 1 : -1;
            }

            return 0;
        }

        public int solution2(int[] arr1, int[] arr2)
        {

            int a = 0;
            int b = 0;

            if (arr1.Length != arr2.Length)
            {
                a = arr1.Length;
                b = arr2.Length;
            }
            else
            {
                a = arr1.Sum();
                b = arr2.Sum();
            }

            if (a == b) return 0;
            return a > b ? 1 : -1;
        }
    }
}
