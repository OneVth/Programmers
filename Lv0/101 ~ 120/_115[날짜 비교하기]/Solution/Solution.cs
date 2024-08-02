using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int[] date1, int[] date2)
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

        public int solution2(int[] date1, int[] date2)
        {
            int d1 = int.Parse($"{date1[0]}{date1[1]}{date1[2]}");
            int d2 = int.Parse($"{date2[0]}{date2[1]}{date2[2]}");

            return d1 < d2 ? 1 : 0;
        }
    }
}
