using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int[] num_list)
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
    }
}
