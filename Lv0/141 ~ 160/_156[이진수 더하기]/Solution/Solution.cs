using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string bin1, string bin2)
        {
            int decBin1 = Convert.ToInt32(bin1, 2);
            int decBin2 = Convert.ToInt32(bin2, 2);

            return Convert.ToString(decBin1 + decBin2, 2);
        }
    }
}
