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
            return num_list.OrderBy(o => o).Skip(5).ToArray();
        }
    }
}
