using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int n, string control)
        {

            foreach (char c in control)
            {
                switch (c)
                {
                    case 'w':
                        n += 1;
                        break;
                    case 's':
                        n -= 1;
                        break;
                    case 'd':
                        n += 10;
                        break;
                    case 'a':
                        n -= 10;
                        break;
                    default:
                        break;
                }
            }

            return n;
        }

        public int solution2(int n, string control)
        {
            return control.Sum(c =>
            'w' == c ? 1 :
            's' == c ? -1 :
            'd' == c ? 10 :
            'a' == c ? -10 : 0) + n;
        }
    }
}
