using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int numer1, int denom1, int numer2, int denom2)
        {
            int newDenom = denom1 * denom2;
            int newNumer = numer1 * denom2 + numer2 * denom1;
            int gcd = GCD(newDenom, newNumer);
            return new int[] { newNumer / gcd, newDenom / gcd };
        }

        public int GCD(int a, int b)
        {
            while (b != 0)
            {
                int tmp = b;
                b = a % b;
                a = tmp;
            }
            return a;
        }
    }
}
