using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public long solution(long n)
        {
            long answer = -1;
            double sqrt = Math.Sqrt(n);


            // for(int i = 1; i * i <= n; i++)
            // {
            //     if(n % i == 0)
            //     {
            //         if(i * i == n)
            //         {
            //             answer = (i + 1) * (i + 1);
            //             break;
            //         }
            //     }
            // }

            return sqrt % 1 == 0 ? (long)Math.Pow(sqrt + 1, 2) : -1;
        }
    }
}
