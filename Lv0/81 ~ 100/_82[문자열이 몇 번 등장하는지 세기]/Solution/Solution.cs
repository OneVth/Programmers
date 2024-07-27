using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(string myString, string pat)
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
    }
}
