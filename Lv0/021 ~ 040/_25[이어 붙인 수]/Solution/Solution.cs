using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int[] num_list)
        {
            StringBuilder sbEven = new StringBuilder();
            StringBuilder sbOdd = new StringBuilder();

            for (int i = 0; i < num_list.Length; i++)
            {
                if (num_list[i] % 2 == 0) sbEven.Append(num_list[i]);
                else sbOdd.Append(num_list[i]);
            }

            string even = sbEven.ToString();
            string odd = sbOdd.ToString();

            return int.Parse(even) + int.Parse(odd);
        }
    }
}
