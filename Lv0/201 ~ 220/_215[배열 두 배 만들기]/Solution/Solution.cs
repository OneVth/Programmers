using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int[] numbers)
        {
            return numbers.Select(s => s * 2).ToArray();
        }
    }
}
