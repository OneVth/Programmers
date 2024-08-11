using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int chicken)
        {
            int nMax = 0;
            int coupon = chicken;

            while (coupon >= 10)
            {
                nMax += coupon / 10;
                coupon = coupon / 10 + coupon % 10;
            }

            return nMax;
        }
    }
}
