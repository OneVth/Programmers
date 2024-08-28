using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public long solution1(long n)
        {
            double sqrt = Math.Sqrt(n);


            // for(int i = 1; i * i <= n; i++)
            // {
            //     if(i * i == n)
            //     {
            //         answer = (i + 1) * (i + 1);
            //         break;
            //     }
            // }
            // 

            return sqrt % 1 == 0 ? (long)Math.Pow(sqrt + 1, 2) : -1;
        }

        public long solution2(long n)
        {
            double sqrt = Math.Sqrt(n);

            return sqrt == (long)sqrt ? (long)Math.Pow(sqrt + 1, 2) : -1;
        }
    }
}
