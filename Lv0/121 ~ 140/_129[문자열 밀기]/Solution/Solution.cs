using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(string A, string B)
        {
            string combined = B + B;
            if (combined.Contains(A))
            {
                if (A == B) return 0;
                else
                    return combined.IndexOf(A);
            }

            return -1;
        }

        public int solution2(string A, string B)
        {
            return (B + B).IndexOf(A);
        }
    }
}
