using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution1(string s, int n)
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

        public string solution2(string s, int n)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in s)
            {
                int nc;
                if (char.IsUpper(c))
                    nc = (c + n - 'A') % 26 + 'A';
                else if (char.IsLower(c))
                    nc = (c + n + 'a') % 26 + 'a';
                else
                    nc = c;

                result.Append((char)nc);
            }

            return result.ToString();
        }
    }
}
