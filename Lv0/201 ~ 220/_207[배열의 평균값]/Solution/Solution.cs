using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public double solution(int[] numbers)
        {
            return (double)numbers.Sum() / numbers.Length;
        }
    }
}
