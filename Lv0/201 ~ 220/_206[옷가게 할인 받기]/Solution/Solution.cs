using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int price)
        {
            double[] discountRate = { 0.8, 0.9, 0.95 };

            if (500000 <= price)
                return (int)(price * discountRate[0]);
            else if (300000 <= price)
                return (int)(price * discountRate[1]);
            else if (100000 <= price)
                return (int)(price * discountRate[2]);
            else
                return price;
        }
    }
}
