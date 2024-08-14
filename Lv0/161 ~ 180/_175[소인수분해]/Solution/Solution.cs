using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int n)
        {
            List<int> factors = new List<int>();

            while (n % 2 == 0)
            {
                factors.Add(2);
                n /= 2;
            }

            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    factors.Add(i);
                    n /= i;
                }
            }

            if (n > 2)
                factors.Add(n);

            return factors.Distinct().ToArray();
        }
    }
}
