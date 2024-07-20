using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soultion
{
    internal class Solution
    {
        public int[] solution(int start_num, int end_num)
        {
            return Enumerable.Range(end_num, start_num - end_num + 1).Reverse().ToArray();
        }
    }
}
