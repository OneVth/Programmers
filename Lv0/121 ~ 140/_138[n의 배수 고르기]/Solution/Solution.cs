using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int n, int[] numlist)
        {
            return numlist.Where(w => w % n == 0).ToArray();
        }
    }
}
