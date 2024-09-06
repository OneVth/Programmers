using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int[] numbers)
        {
            int[] cmpArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            return cmpArray.Except(numbers).Sum();
        }
    }
}
