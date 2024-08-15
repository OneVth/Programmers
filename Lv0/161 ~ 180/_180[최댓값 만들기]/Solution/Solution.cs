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
            return numbers.OrderByDescending(o => o).Take(2).Aggregate((x, y) => x * y);
        }
    }
}
