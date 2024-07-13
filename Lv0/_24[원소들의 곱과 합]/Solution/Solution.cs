using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int[] num_list)
        {
            int product = 1;
            int sum = 0;

            foreach (var n in num_list)
            {
                sum += n;
                product *= n;
            }

            return Math.Pow(sum, 2) >= product ? 1 : 0;
        }

        public int solution2(int[] num_list)
        {
            int answer = 0;

            answer = num_list.Aggregate(1, (x, y) => x * y) < Math.Pow(num_list.Sum(), 2) ? 1 : 0;

            return answer;
        }
    }
}
