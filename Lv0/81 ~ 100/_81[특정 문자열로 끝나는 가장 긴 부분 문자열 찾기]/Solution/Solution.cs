using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution1(string myString, string pat)
        {
            int length = myString.LastIndexOf(pat) + pat.Length;
            char[] answer = new char[length];

            myString.CopyTo(0, answer, 0, length);
            return new string(answer);
        }

        public string solution2(string myString, string pat)
        {
            return myString.Substring(0, myString.LastIndexOf(pat) + pat.Length);
        }
    }
}
