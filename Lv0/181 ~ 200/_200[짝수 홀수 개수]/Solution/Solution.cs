using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int[] num_list)
        {
            int[] oddOrEven = new int[2];

            oddOrEven[0] = num_list.Count(x => x % 2 == 0);
            oddOrEven[1] = num_list.Count(x => x % 2 == 1);

            return oddOrEven;
        }
    }
}
