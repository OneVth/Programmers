using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int[] box, int n)
        {
            return (box[0] / n) * (box[1] / n) * (box[2] / n);
        }
    }
}
