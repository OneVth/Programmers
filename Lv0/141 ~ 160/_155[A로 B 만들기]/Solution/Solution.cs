using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(string before, string after)
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

        public int solution2(string before, string after)
        {
            char[] beforeArr = before.ToCharArray();
            char[] afterArr = after.ToCharArray();
            Array.Sort(beforeArr);
            Array.Sort(afterArr);
            for (int i = 0; i < beforeArr.Length; i++)
            {
                if (beforeArr[i] != afterArr[i])
                    return 0;
            }
            return 1;
        }

        public int solution3(string before, string after)
        {
            return String.Concat(before.OrderBy(x => x)) == String.Concat(after.OrderBy(x => x)) ? 1 : 0;
        }
    }
}
