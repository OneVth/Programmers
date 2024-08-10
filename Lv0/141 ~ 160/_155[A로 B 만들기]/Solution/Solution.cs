using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(string before, string after)
        {
            char[] distinctedA = after.Distinct().OrderBy(o => o).ToArray();
            char[] distinctedB = before.Distinct().OrderBy(o => o).ToArray();

            if (!distinctedA.SequenceEqual(distinctedB))
                return 0;

            foreach (char c in distinctedA)
            {
                int countedA = after.Count(x => x == c);
                int countedB = before.Count(x => x == c);
                if (countedA != countedB)
                    return 0;
            }

            return 1;
        }
    }
}
