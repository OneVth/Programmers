using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int n, int m)
        {
            return new int[] { GCD(n, m), LCM(n, m) };
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

        public int LCM(int a, int b)
        {
            return (a / GCD(a, b)) * b;
        }
    }
}
