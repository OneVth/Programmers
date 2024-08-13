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

            if (numbers.Length == 2)
                return numbers[0] * numbers[1];

            int negMaxProduct = 0;
            int posMaxProduct = 0;

            int[] negative = numbers.Where(w => 0 > w).Select(s => Math.Abs(s)).OrderByDescending(o => o).ToArray();
            int[] positive = numbers.Where(w => 0 <= w).OrderByDescending(o => o).ToArray();

            if (negative.Length >= 2)
                negMaxProduct = negative[0] * negative[1];
            if (positive.Length >= 2)
                posMaxProduct = positive[0] * positive[1];

            return negMaxProduct > posMaxProduct ? negMaxProduct : posMaxProduct;
        }
    }
}
