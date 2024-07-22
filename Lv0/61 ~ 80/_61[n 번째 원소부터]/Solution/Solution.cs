using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int[] num_list, int n)
        {
            return num_list.Skip(n - 1).ToArray();
        }
    }
}
