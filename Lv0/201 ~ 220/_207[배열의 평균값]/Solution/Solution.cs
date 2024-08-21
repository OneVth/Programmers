using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public double solution1(int[] numbers)
        {
            return (double)numbers.Sum() / numbers.Length;
        }

        public double solution2(int[] numbers)
        {
            return numbers.Average();
        }
    }
}
