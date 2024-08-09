using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution1(string cipher, int code)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = code - 1; i < cipher.Length; i += code)
            {
                sb.Append(cipher[i]);
            }

            return sb.ToString();
        }

        public string solution2(string cipher, int code)
        {
            return String.Concat(cipher.Where((x, i) => (i + 1) % code == 0));
        }
    }
}
