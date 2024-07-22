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
            return num_list.Where((w, index) => index % n == 0).ToArray();
        }
    }
}
