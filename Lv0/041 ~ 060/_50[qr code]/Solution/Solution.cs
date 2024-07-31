using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution1(int q, int r, string code)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < code.Length; i++)
            {
                if (i % q == r) sb.Append(code[i]);
            }
            return sb.ToString();
        }

        public string solution2(int q, int r, string code)
        {
            return new string(code.Where((w, index) => index % q == r).ToArray());
        }
    }
}
