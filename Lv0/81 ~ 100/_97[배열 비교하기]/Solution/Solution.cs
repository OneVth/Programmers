using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int[] arr1, int[] arr2)
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
    }
}
