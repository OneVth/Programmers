﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string s)
        {
            return new string(s.OrderByDescending(o => o).ToArray());
        }
    }
}
