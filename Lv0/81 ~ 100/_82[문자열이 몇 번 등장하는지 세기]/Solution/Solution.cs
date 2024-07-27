using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(string myString, string pat)
        {
            int result = 0;
            int count = 0;

            result = myString.IndexOf(pat, 0, myString.Length - 1);

            while (result != -1)
            {
                count++;
                result = myString.IndexOf(pat, result + 1, myString.Length - result - 1);
            }

            return count;
        }

        public int solution2(string myString, string pat)
        {
            int answer = 0;
            int lastIndex = 0;

            while (true)
            {
                lastIndex = myString.IndexOf(pat, lastIndex);
                if (lastIndex == -1) break;

                ++lastIndex;
                ++answer;
            }

            return answer;
        }
    }
}
