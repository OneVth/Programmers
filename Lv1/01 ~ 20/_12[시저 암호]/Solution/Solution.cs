using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string s, int n)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in s)
            {
                int nc;
                if (c >= 'A' && c <= 'Z')
                {
                    if (c + n > 'Z')
                        nc = c + n - 26;
                    else
                        nc = c + n;
                }
                else if (c >= 'a' && c <= 'z')
                {
                    if (c + n > 'z')
                        nc = c + n - 26;
                    else
                        nc = c + n;
                }
                else
                    nc = ' ';

                sb.Append((char)nc);
            }

            return sb.ToString();
        }
    }
}
