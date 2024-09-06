using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public long solution(int price, int money, int count)
        {
            // a = price, d = price인 등차수열
            long reqPrice = 0;
            long totPrice = 0;

            totPrice = (((long)count + 1) * price * count) / 2;
            reqPrice = totPrice - money;

            return reqPrice > 0 ? reqPrice : 0;
        }
    }
}
