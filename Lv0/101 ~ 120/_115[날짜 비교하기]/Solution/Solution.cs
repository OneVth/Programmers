using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int[] date1, int[] date2)
        {

            if (date1[0] != date2[0])
                return date1[0] < date2[0] ? 1 : 0;
            else
            {
                if (date1[1] != date2[1])
                    return date1[1] < date2[1] ? 1 : 0;
                else
                {
                    if (date1[2] != date2[2])
                        return date1[2] < date2[2] ? 1 : 0;
                    else
                        return 0;
                }
            }
        }
    }
}
