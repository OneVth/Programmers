using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int n)
        {
            bool[] PrimeArray = Enumerable.Repeat<bool>(true, n + 1).ToArray();

            for (int i = 2; (i * i) <= n; i++)
                if (PrimeArray[i])
                    for (int j = i * i; j <= n; j += i)
                        PrimeArray[j] = false;

            // 0, 1은 제외하고 카운트
            return PrimeArray.Skip(2).Count(x => x);
        }
    }
}
