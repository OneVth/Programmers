using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int[] array, int height)
        {
            return array.Where(w => w > height).Count();
        }
    }
}
