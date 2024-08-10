using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int[] sides)
        {
            return (sides.Max() < sides.Sum() - sides.Max()) ? 1 : 2;
        }
    }
}
