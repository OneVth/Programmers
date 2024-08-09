using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string cipher, int code)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = code - 1; i < cipher.Length; i += code)
            {
                sb.Append(cipher[i]);
            }

            return sb.ToString();
        }
    }
}
