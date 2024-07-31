using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int[] rank, bool[] attendance)
        {
            int answer = 0;

            int[] topThree = rank.Where((w, index) => attendance[index]).OrderBy(o => o).Take(3).ToArray();

            int a = Array.IndexOf(rank, topThree[0]);
            int b = Array.IndexOf(rank, topThree[1]);
            int c = Array.IndexOf(rank, topThree[2]);

            return 10000 * a + 100 * b + c;
        }
    }
}
