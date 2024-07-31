﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int[] num_list)
        {
            for (int i = 0; i < num_list.Length; i++)
                if (num_list[i] < 0) return i;

            return -1;
        }

        public int solution2(int[] num_list)
        {
            return Array.FindIndex(num_list, f => f < 0);
        }
    }
}
